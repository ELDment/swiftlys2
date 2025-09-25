using System.Buffers;
using System.Text;
using Spectre.Console;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class GameFunctions {

  public static unsafe delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, void> pCTakeDamageInfo_Constructor;
  public static unsafe delegate* unmanaged<nint, Ray_t, Vector, Vector, CTraceFilter*, CGameTrace*, void> pTraceShape;
  public static unsafe delegate* unmanaged<Vector, Vector, BBox_t, CTraceFilter*, CGameTrace*, void> pTracePlayerBBox;
  public static unsafe delegate* unmanaged<nint, IntPtr, void> pSetModel;
  public static unsafe delegate* unmanaged<nint, nint, bool, bool, bool, bool, void> pSetPlayerControllerPawn;
  public static int TeleportOffset => NativeOffsets.Fetch("CBaseEntity::Teleport");
  public static int CommitSuicideOffset => NativeOffsets.Fetch("CBasePlayerPawn::CommitSuicide");
  public static int GetSkeletonInstanceOffset => NativeOffsets.Fetch("CGameSceneNode::GetSkeletonInstance");
  public static int FindPickerEntityOffset => NativeOffsets.Fetch("CGameRules::FindPickerEntity");
  public static int RemoveWeaponsOffset => NativeOffsets.Fetch("CCSPlayer_ItemServices::RemoveWeapons");
  public static int GiveNamedItemOffset => NativeOffsets.Fetch("CCSPlayer_ItemServices::GiveNamedItem");
  public static int DropActiveItemOffset => NativeOffsets.Fetch("CCSPlayer_ItemServices::DropActiveItem");
  public static int DropWeaponOffset => NativeOffsets.Fetch("CCSPlayer_WeaponServices::DropWeapon");
  public static int SelectWeaponOffset => NativeOffsets.Fetch("CCSPlayer_WeaponServices::SelectWeapon");

  public static void Initialize() {
    unsafe {
      pCTakeDamageInfo_Constructor = (delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, void>)NativeSignatures.Fetch("CTakeDamageInfo::Constructor");
      pTraceShape = (delegate* unmanaged<nint, Ray_t, Vector, Vector, CTraceFilter*, CGameTrace*, void>)NativeSignatures.Fetch("TraceShape");
      pTracePlayerBBox = (delegate* unmanaged<Vector, Vector, BBox_t, CTraceFilter*, CGameTrace*, void>)NativeSignatures.Fetch("TracePlayerBBox");
      pSetModel = (delegate* unmanaged<nint, IntPtr, void>)NativeSignatures.Fetch("CBaseModelEntity::SetModel");
      pSetPlayerControllerPawn = (delegate* unmanaged<nint, nint, bool, bool, bool, bool, void>)NativeSignatures.Fetch("CBasePlayerController::SetPawn");
    }
  }

  public unsafe static nint FindPickerEntity(nint handle, nint controller)
  {
    try
    {
      unsafe
      {
        void*** ppVTable = (void***)handle;
        var pFindPickerEntity = (delegate* unmanaged<nint, nint, nint, nint>)ppVTable[0][FindPickerEntityOffset];
        return pFindPickerEntity(handle, controller, IntPtr.Zero);
      }
    }
    catch (Exception e)
    {
      AnsiConsole.WriteException(e);
    }
    return 0;
  }

  public unsafe static nint GetSkeletonInstance(nint handle)
  {
    try
    {
      unsafe
      {
        void*** ppVTable = (void***)handle;
        var pSkeletonInstance = (delegate* unmanaged<nint, nint>)ppVTable[0][GetSkeletonInstanceOffset];
        return pSkeletonInstance(handle);
      }
    }
    catch (Exception e)
    {
      AnsiConsole.WriteException(e);
    }
    return 0;
  }

  public unsafe static void PawnCommitSuicide(nint pPawn, bool bExplode, bool bForce)
  {
    try
    {
      unsafe
      {
        void*** ppVTable = (void***)pPawn;
        var pCommitSuicide = (delegate* unmanaged<nint, bool, bool, void>)ppVTable[0][CommitSuicideOffset];
        pCommitSuicide(pPawn, bExplode, bForce);
      }
    } catch (Exception e)
    {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void SetPlayerControllerPawn(nint pController, nint pPawn, bool b1, bool b2, bool b3, bool b4)
  {
    try {
      unsafe {
        pSetPlayerControllerPawn(pController, pPawn, b1, b2, b3, b4);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void SetModel(nint pEntity, string model)
  {
    try {
      unsafe {
        var pool = ArrayPool<byte>.Shared;
        var modelLength = Encoding.UTF8.GetByteCount(model);
        var modelBuffer = pool.Rent(modelLength + 1);
        Encoding.UTF8.GetBytes(model, modelBuffer);
        modelBuffer[modelLength] = 0;
        fixed (byte* pModel = modelBuffer) {
          pSetModel(pEntity, (IntPtr)pModel);
          pool.Return(modelBuffer);
        }
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
    }

    public unsafe static void Teleport(
    nint pEntity,
    Vector* vecPosition,
    QAngle* vecAngle,
    Vector* vecVelocity
  )
  {
    try {
      unsafe {
        void*** ppVTable = (void***)pEntity;
        var pTeleport = (delegate* unmanaged<nint, Vector*, QAngle*, Vector*, void>)ppVTable[0][TeleportOffset];
        pTeleport(pEntity, vecPosition, vecAngle, vecVelocity);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void TracePlayerBBox(
    Vector vecStart,
    Vector vecEnd,
    BBox_t bounds,
    CTraceFilter* pFilter,
    CGameTrace* pTrace
  )
  {
    try {
      unsafe {
        pTracePlayerBBox(vecStart, vecEnd, bounds, pFilter, pTrace);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void TraceShape(
    nint pEngineTrace,
    Ray_t ray,
    Vector vecStart,
    Vector vecEnd,
    CTraceFilter* pFilter,
    CGameTrace* pTrace
  )
  {
    try {
      unsafe {
        pTraceShape(pEngineTrace, ray, vecStart, vecEnd, pFilter, pTrace);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void CTakeDamageInfoConstructor(
    CTakeDamageInfo* pThis,
    nint pInflictor,
    nint pAttacker,
    nint pAbility,
    Vector* vecDamageForce,
    Vector* vecDamagePosition,
    float flDamage,
    int bitsDamageType,
    int iCustomDamage,
    void* a10
  )
  {
    try {
      unsafe {
        pCTakeDamageInfo_Constructor(pThis, pInflictor, pAttacker, pAbility, vecDamageForce, vecDamagePosition, flDamage, bitsDamageType, iCustomDamage, a10);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void CCSPlayer_ItemServices_RemoveWeapons(nint pThis) {
    try {
      unsafe {
        void*** ppVTable = (void***)pThis;
        var pRemoveWeapons = (delegate* unmanaged<nint, void>)ppVTable[0][RemoveWeaponsOffset];
        pRemoveWeapons(pThis);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static nint CCSPlayer_ItemServices_GiveNamedItem(nint pThis, string name) {
    try {
      unsafe {
        void*** ppVTable = (void***)pThis;
        var pGiveNamedItem = (delegate* unmanaged<nint, nint, nint>)ppVTable[0][GiveNamedItemOffset];
        var pool = ArrayPool<byte>.Shared;
        var nameLength = Encoding.UTF8.GetByteCount(name);
        var nameBuffer = pool.Rent(nameLength + 1);
        Encoding.UTF8.GetBytes(name, nameBuffer);
        nameBuffer[nameLength] = 0;
        fixed (byte* pName = nameBuffer) {
          return pGiveNamedItem(pThis, (IntPtr)pName);
        }
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
      return 0;
    }
  }

  public unsafe static void CCSPlayer_ItemServices_DropActiveItem(nint pThis, Vector momentum) {
    try {
      unsafe {
        void*** ppVTable = (void***)pThis;
        var pDropActiveItem = (delegate* unmanaged<nint, Vector*, void>)ppVTable[0][DropActiveItemOffset];
        pDropActiveItem(pThis, &momentum);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    } 
  }

  public unsafe static void CCSPlayer_WeaponServices_DropWeapon(nint pThis, nint pWeapon) {
    try {
      unsafe {
        void*** ppVTable = (void***)pThis;
        var pDropWeapon = (delegate* unmanaged<nint, nint, void>)ppVTable[0][DropWeaponOffset];
        pDropWeapon(pThis, pWeapon);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void CCSPlayer_WeaponServices_SelectWeapon(nint pThis, nint pWeapon) {
    try {
      unsafe {
        void*** ppVTable = (void***)pThis;
        var pSelectWeapon = (delegate* unmanaged<nint, nint, void>)ppVTable[0][SelectWeaponOffset];
        pSelectWeapon(pThis, pWeapon);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    } 
  }
}