
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_ClientRequestSouvenir : ITypedProtobuf<CMsgGCCStrike15_v2_ClientRequestSouvenir>
{
  static CMsgGCCStrike15_v2_ClientRequestSouvenir ITypedProtobuf<CMsgGCCStrike15_v2_ClientRequestSouvenir>.Wrap(nint handle) => new CMsgGCCStrike15_v2_ClientRequestSouvenirImpl(handle);


  public ulong Itemid { get; set; }


  public ulong Matchid { get; set; }


  public int Eventid { get; set; }

}
