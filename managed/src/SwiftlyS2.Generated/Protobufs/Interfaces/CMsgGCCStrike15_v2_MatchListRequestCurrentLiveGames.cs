
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames : ITypedProtobuf<CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames>
{
  static CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames ITypedProtobuf<CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGames>.Wrap(nint handle) => new CMsgGCCStrike15_v2_MatchListRequestCurrentLiveGamesImpl(handle);


}
