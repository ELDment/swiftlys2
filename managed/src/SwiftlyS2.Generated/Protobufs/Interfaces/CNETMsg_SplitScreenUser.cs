
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CNETMsg_SplitScreenUser : ITypedProtobuf<CNETMsg_SplitScreenUser>, INetMessage<CNETMsg_SplitScreenUser>
{
  static int INetMessage<CNETMsg_SplitScreenUser>.MessageId => 3;
  
  static string INetMessage<CNETMsg_SplitScreenUser>.MessageName => "CNETMsg_SplitScreenUser";

  static CNETMsg_SplitScreenUser ITypedProtobuf<CNETMsg_SplitScreenUser>.Wrap(nint handle) => new CNETMsg_SplitScreenUserImpl(handle);


  public int Slot { get; set; }

}
