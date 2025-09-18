
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSOEconItemEquipped : ITypedProtobuf<CSOEconItemEquipped>
{
  static CSOEconItemEquipped ITypedProtobuf<CSOEconItemEquipped>.Wrap(nint handle) => new CSOEconItemEquippedImpl(handle);


  public uint NewClass { get; set; }


  public uint NewSlot { get; set; }

}
