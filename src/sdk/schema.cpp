/************************************************************************************************
 *  SwiftlyS2 is a scripting framework for Source2-based games.
 *  Copyright (C) 2025 Swiftly Solution SRL via Sava Andrei-Sebastian and it's contributors
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 ************************************************************************************************/

#include "schema.h"

#include <format>
#include <map>

#include <api/interfaces/manager.h>
#include <api/shared/files.h>
#include <api/shared/jsonc.h>
#include <api/shared/plat.h>
#include <api/memory/virtual/call.h>

#define CBaseEntity_m_nSubclassID 0x9DC483B8C02CE796

std::map<uint64_t, SchemaField> offsets;
std::map<uint32_t, SchemaClass> classes;

class CNetworkVarChainer
{
public:
	CEntityInstance* m_pEntity;

private:
	uint8 pad_0000[24];

public:
	ChangeAccessorFieldPathIndex_t m_PathIndex;

private:
	uint8 pad_0024[4];
};

void CSDKSchema::Load()
{
	auto schemaSystem = g_ifaceService.FetchInterface<CSchemaSystem>(SCHEMASYSTEM_INTERFACE_VERSION);
	auto logger = g_ifaceService.FetchInterface<ILogger>(LOGGER_INTERFACE_VERSION);

	json sdkJson;

	logger->Info("SDK", "Loading SDK classes...\n");

	auto gts = schemaSystem->GlobalTypeScope();

	int classes_count = gts->m_DeclaredClasses.m_Map.Count();

	FOR_EACH_MAP(gts->m_DeclaredClasses.m_Map, iter)
	{
		ReadClasses(gts->m_DeclaredClasses.m_Map.Element(iter), sdkJson);
	}

	for (int i = 0; i < schemaSystem->m_TypeScopes.GetNumStrings(); i++)
	{
		auto ts = schemaSystem->m_TypeScopes[i];

		classes_count += ts->m_DeclaredClasses.m_Map.Count();

		FOR_EACH_MAP(ts->m_DeclaredClasses.m_Map, iter)
		{
			ReadClasses(ts->m_DeclaredClasses.m_Map.Element(iter), sdkJson);
		}
	}

	logger->Info("SDK", std::format("Finished loading {} SDK classes ({} fields).\n", classes_count, offsets.size()));

	logger->Info("SDK", "Loading SDK enums...\n");

	int enums_count = gts->m_DeclaredEnums.m_Map.Count();

	FOR_EACH_MAP(gts->m_DeclaredEnums.m_Map, iter)
	{
		ReadEnums(gts->m_DeclaredEnums.m_Map.Element(iter), sdkJson);
	}

	for (int i = 0; i < schemaSystem->m_TypeScopes.GetNumStrings(); i++)
	{
		auto ts = schemaSystem->m_TypeScopes[i];

		enums_count += ts->m_DeclaredEnums.m_Map.Count();

		FOR_EACH_MAP(ts->m_DeclaredEnums.m_Map, iter)
		{
			ReadEnums(ts->m_DeclaredEnums.m_Map.Element(iter), sdkJson);
		}
	}

	logger->Info("SDK", std::format("Finished loading {} SDK enums.\n", enums_count));

	WriteJSON("addons/swiftly/gamedata/cs2/sdk.json", sdkJson);
}

void CSDKSchema::SetStateChanged(void* pEntity, const char* sClassName, const char* sMemberName)
{
	uint32_t class_hash = hash_32_fnv1a_const(sClassName);
	uint64_t fieldHash = ((uint64_t)(class_hash) << 32 | hash_32_fnv1a_const(sMemberName));

	SetStateChanged(pEntity, fieldHash);
}

void CSDKSchema::SetStateChanged(void* pEntity, uint64_t uHash)
{
	auto fieldData = offsets.find(uHash);
	if (fieldData == offsets.end()) return;

	auto& fieldInfo = fieldData->second;
	if (!fieldInfo.m_bNetworked) return;

	if (fieldInfo.m_bChainer) {
		CNetworkVarChainer* pChainer = (CNetworkVarChainer*)((uintptr_t)pEntity + fieldInfo.m_nChainerOffset);

		CEntityInstance* pEntity = pChainer->m_pEntity;
		if (pEntity)
			pEntity->NetworkStateChanged(NetworkStateChangedData(fieldInfo.m_uOffset, -1, pChainer->m_PathIndex));
	}
	else if (fieldInfo.m_bIsStruct) {
		NetworkStateChangedData data(fieldInfo.m_uOffset);
		CALL_VIRTUAL(void, WIN_LINUX(27, 28), pEntity, &data);
	}
	else {
		reinterpret_cast<CEntityInstance*>(pEntity)->NetworkStateChanged(NetworkStateChangedData(fieldInfo.m_uOffset));
	}
}

int32_t CSDKSchema::FindChainOffset(const char* sClassName)
{
	return GetOffset(sClassName, "__m_pChainEntity");
}

int32_t CSDKSchema::GetOffset(const char* sClassName, const char* sMemberName)
{
	uint32_t class_hash = hash_32_fnv1a_const(sClassName);
	uint64_t fieldHash = ((uint64_t)(class_hash) << 32 | hash_32_fnv1a_const(sMemberName));
	return GetOffset(fieldHash);
}

int32_t CSDKSchema::GetOffset(uint64_t uHash)
{
	auto it = offsets.find(uHash);
	if (it == offsets.end()) return 0;
	else return it->second.m_uOffset;
}

bool CSDKSchema::IsStruct(const char* sClassName)
{
	auto it = classes.find(hash_32_fnv1a_const(sClassName));
	if (it == classes.end()) return false;
	return it->second.m_bIsStruct;
}

bool CSDKSchema::IsClassLoaded(const char* sClassName)
{
	return classes.contains(hash_32_fnv1a_const(sClassName));
}

void* CSDKSchema::GetPropPtr(void* pEntity, const char* sClassName, const char* sMemberName)
{
	uint32_t class_hash = hash_32_fnv1a_const(sClassName);
	uint64_t fieldHash = ((uint64_t)(class_hash) << 32 | hash_32_fnv1a_const(sMemberName));

	return GetPropPtr(pEntity, fieldHash);
}

void* CSDKSchema::GetPropPtr(void* pEntity, uint64_t uHash)
{
	auto it = offsets.find(uHash);
	if (it == offsets.end()) return nullptr;

	auto& fieldInfo = it->second;
	return reinterpret_cast<void*>((uintptr_t)pEntity + fieldInfo.m_uOffset);
}

void CSDKSchema::WritePropPtr(void* pEntity, const char* sClassName, const char* sMemberName, void* pValue, uint32_t size)
{
	uint32_t class_hash = hash_32_fnv1a_const(sClassName);
	uint64_t fieldHash = ((uint64_t)(class_hash) << 32 | hash_32_fnv1a_const(sMemberName));

	WritePropPtr(pEntity, fieldHash, pValue, size);
}

void CSDKSchema::WritePropPtr(void* pEntity, uint64_t uHash, void* pValue, uint32_t size)
{
	void* propPtr = GetPropPtr(pEntity, uHash);
	if (!propPtr) return;

	Plat_WriteMemory(propPtr, (uint8_t*)pValue, size);
}

void* CSDKSchema::GetVData(void* pEntity)
{
	void* subclassPtr = GetPropPtr(pEntity, CBaseEntity_m_nSubclassID);
	return *(void**)((uintptr_t)subclassPtr + 4);
}