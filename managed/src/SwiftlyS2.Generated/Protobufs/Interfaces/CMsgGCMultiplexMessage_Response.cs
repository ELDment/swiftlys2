
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCMultiplexMessage_Response : ITypedProtobuf<CMsgGCMultiplexMessage_Response>
{
  static CMsgGCMultiplexMessage_Response ITypedProtobuf<CMsgGCMultiplexMessage_Response>.Wrap(nint handle) => new CMsgGCMultiplexMessage_ResponseImpl(handle);


  public uint Msgtype { get; set; }

}
