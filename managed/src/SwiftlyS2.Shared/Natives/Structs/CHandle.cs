using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.Natives;

public interface ICHandle
{
    public uint Raw { get; }
}

[StructLayout(LayoutKind.Sequential, Size = 4)]
public struct CHandle<T>( uint raw ) : ICHandle where T : class, ISchemaClass<T>
{
    public uint Raw { get; set; } = raw;
    public readonly uint EntityIndex => Raw & 0x7FFF;
    public readonly uint SerialNumber => (Raw >> 15) & 0x1FFFF;

    public readonly bool IsValid => NativeEntitySystem.EntityHandleIsValid(Raw);

    public T? Value {
        readonly get {
            unsafe
            {
                return IsValid ? (T?)T.From(NativeEntitySystem.EntityHandleGet(Raw)) : null;
            }
        }
        set {
            Raw = value is null ? 0xFFFFFFFF : NativeEntitySystem.GetEntityHandleFromEntity(value.Address);
        }
    }

    public static CHandle<T> Invalid => new(0xFFFFFFFF);

    public static implicit operator T( CHandle<T> handle ) => handle.Value ?? throw new InvalidOperationException("Entity handle is invalid or entity does not exist.");
}