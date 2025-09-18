
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_Fantasy_FantasyTeam : ITypedProtobuf<CMsgGCCStrike15_v2_Fantasy_FantasyTeam>
{
  static CMsgGCCStrike15_v2_Fantasy_FantasyTeam ITypedProtobuf<CMsgGCCStrike15_v2_Fantasy_FantasyTeam>.Wrap(nint handle) => new CMsgGCCStrike15_v2_Fantasy_FantasyTeamImpl(handle);


  public int Sectionid { get; set; }


  public IProtobufRepeatedFieldSubMessageType<CMsgGCCStrike15_v2_Fantasy_FantasySlot> Slots { get; }

}
