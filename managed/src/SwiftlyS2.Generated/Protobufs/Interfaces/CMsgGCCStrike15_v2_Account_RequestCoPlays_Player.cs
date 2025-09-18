
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_Account_RequestCoPlays_Player : ITypedProtobuf<CMsgGCCStrike15_v2_Account_RequestCoPlays_Player>
{
  static CMsgGCCStrike15_v2_Account_RequestCoPlays_Player ITypedProtobuf<CMsgGCCStrike15_v2_Account_RequestCoPlays_Player>.Wrap(nint handle) => new CMsgGCCStrike15_v2_Account_RequestCoPlays_PlayerImpl(handle);


  public uint Accountid { get; set; }


  public uint Rtcoplay { get; set; }


  public bool Online { get; set; }

}
