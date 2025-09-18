
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface NetMessageConnectionCrashed : ITypedProtobuf<NetMessageConnectionCrashed>
{
  static NetMessageConnectionCrashed ITypedProtobuf<NetMessageConnectionCrashed>.Wrap(nint handle) => new NetMessageConnectionCrashedImpl(handle);


  public uint Reason { get; set; }


  public string Message { get; set; }

}
