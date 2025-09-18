
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCLCMsg_SplitPlayerDisconnect : ITypedProtobuf<CCLCMsg_SplitPlayerDisconnect>, INetMessage<CCLCMsg_SplitPlayerDisconnect>
{
  static int INetMessage<CCLCMsg_SplitPlayerDisconnect>.MessageId => 30;
  
  static string INetMessage<CCLCMsg_SplitPlayerDisconnect>.MessageName => "CCLCMsg_SplitPlayerDisconnect";

  static CCLCMsg_SplitPlayerDisconnect ITypedProtobuf<CCLCMsg_SplitPlayerDisconnect>.Wrap(nint handle) => new CCLCMsg_SplitPlayerDisconnectImpl(handle);


  public int Slot { get; set; }

}
