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

#ifndef src_engine_convars_convars_h
#define src_engine_convars_convars_h

#include <api/engine/convars/convars.h>

class CConvarManager : public IConvarManager
{
public:
    virtual void Initialize() override;
    virtual void Shutdown() override;

    virtual void QueryClientConvar(int playerid, std::string cvar_name) override;
    virtual int AddQueryClientCvarCallback(std::function<void(int, std::string, std::string)> callback) override;
    virtual void RemoveQueryClientCvarCallback(int callback_id) override;
    virtual void OnClientQueryCvar(int playerid, std::string cvar_name, std::string cvar_value) override;

    virtual void CreateConvar(std::string cvar_name, EConVarType type, uint64_t flags, const char* help_message, ConvarValue defaultValue) override;
    virtual void DeleteConvar(std::string cvar_name) override;
    virtual bool ExistsConvar(std::string cvar_name) override;
    virtual EConVarType GetConvarType(std::string cvar_name) override;

    virtual void* GetConvarDataAddress(std::string cvar_name) override;
    virtual ConvarValue GetConvarValue(std::string cvar_name) override;

    virtual void SetConvarValue(std::string cvar_name, ConvarValue value) override;
    virtual void SetClientConvar(int playerid, std::string cvar_name, ConvarValue value) override;

    virtual void AddFlags(std::string cvar_name, uint64_t flags) override;
    virtual void RemoveFlags(std::string cvar_name, uint64_t flags) override;
    virtual void ClearFlags(std::string cvar_name) override;
    virtual uint64_t GetFlags(std::string cvar_name) override;
};

#endif