#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeSchema {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<nint, ulong, void> _SetStateChanged;
  public unsafe static void SetStateChanged(nint entity, ulong hash) {
    try {
    _SetStateChanged(entity, hash);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, uint> _FindChainOffset;
  public unsafe static uint FindChainOffset(string className) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var classNameLength = Encoding.UTF8.GetByteCount(className);
    var classNameBuffer = pool.Rent(classNameLength + 1);
    Encoding.UTF8.GetBytes(className, classNameBuffer);
    classNameBuffer[classNameLength] = 0;
    fixed (byte* classNameBufferPtr = classNameBuffer) {
        var ret = _FindChainOffset(classNameBufferPtr);
    pool.Return(classNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<ulong, int> _GetOffset;
  public unsafe static int GetOffset(ulong hash) {
    try {
    var ret = _GetOffset(hash);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _IsStruct;
  public unsafe static bool IsStruct(string className) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var classNameLength = Encoding.UTF8.GetByteCount(className);
    var classNameBuffer = pool.Rent(classNameLength + 1);
    Encoding.UTF8.GetBytes(className, classNameBuffer);
    classNameBuffer[classNameLength] = 0;
    fixed (byte* classNameBufferPtr = classNameBuffer) {
        var ret = _IsStruct(classNameBufferPtr);
    pool.Return(classNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _IsClassLoaded;
  public unsafe static bool IsClassLoaded(string className) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var classNameLength = Encoding.UTF8.GetByteCount(className);
    var classNameBuffer = pool.Rent(classNameLength + 1);
    Encoding.UTF8.GetBytes(className, classNameBuffer);
    classNameBuffer[classNameLength] = 0;
    fixed (byte* classNameBufferPtr = classNameBuffer) {
        var ret = _IsClassLoaded(classNameBufferPtr);
    pool.Return(classNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, ulong, nint> _GetPropPtr;
  public unsafe static nint GetPropPtr(nint entity, ulong hash) {
    try {
    var ret = _GetPropPtr(entity, hash);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, ulong, nint, uint, void> _WritePropPtr;
  public unsafe static void WritePropPtr(nint entity, ulong hash, nint value, uint size) {
    try {
    _WritePropPtr(entity, hash, value, size);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, nint> _GetVData;
  public unsafe static nint GetVData(nint entity) {
    try {
    var ret = _GetVData(entity);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
