
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCClientVersionUpdated : ITypedProtobuf<CMsgGCClientVersionUpdated>
{
  static CMsgGCClientVersionUpdated ITypedProtobuf<CMsgGCClientVersionUpdated>.Wrap(nint handle) => new CMsgGCClientVersionUpdatedImpl(handle);


  public uint ClientVersion { get; set; }

}
