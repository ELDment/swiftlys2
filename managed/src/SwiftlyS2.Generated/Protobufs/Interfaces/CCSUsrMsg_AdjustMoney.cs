
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_AdjustMoney : ITypedProtobuf<CCSUsrMsg_AdjustMoney>, INetMessage<CCSUsrMsg_AdjustMoney>
{
  static int INetMessage<CCSUsrMsg_AdjustMoney>.MessageId => 327;
  
  static string INetMessage<CCSUsrMsg_AdjustMoney>.MessageName => "CCSUsrMsg_AdjustMoney";

  static CCSUsrMsg_AdjustMoney ITypedProtobuf<CCSUsrMsg_AdjustMoney>.Wrap(nint handle) => new CCSUsrMsg_AdjustMoneyImpl(handle);


  public int Amount { get; set; }

}
