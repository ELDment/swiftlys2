
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_CurrentRoundOdds : ITypedProtobuf<CCSUsrMsg_CurrentRoundOdds>, INetMessage<CCSUsrMsg_CurrentRoundOdds>
{
  static int INetMessage<CCSUsrMsg_CurrentRoundOdds>.MessageId => 380;
  
  static string INetMessage<CCSUsrMsg_CurrentRoundOdds>.MessageName => "CCSUsrMsg_CurrentRoundOdds";

  static CCSUsrMsg_CurrentRoundOdds ITypedProtobuf<CCSUsrMsg_CurrentRoundOdds>.Wrap(nint handle) => new CCSUsrMsg_CurrentRoundOddsImpl(handle);


  public int Odds { get; set; }

}
