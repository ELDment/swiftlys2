
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_MatchEndRewardDropsNotification : ITypedProtobuf<CMsgGCCStrike15_v2_MatchEndRewardDropsNotification>
{
  static CMsgGCCStrike15_v2_MatchEndRewardDropsNotification ITypedProtobuf<CMsgGCCStrike15_v2_MatchEndRewardDropsNotification>.Wrap(nint handle) => new CMsgGCCStrike15_v2_MatchEndRewardDropsNotificationImpl(handle);


  public CEconItemPreviewDataBlock Iteminfo { get; }

}
