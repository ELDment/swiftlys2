
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_ClientToGCRequestTicket : ITypedProtobuf<CMsgGCCStrike15_v2_ClientToGCRequestTicket>
{
  static CMsgGCCStrike15_v2_ClientToGCRequestTicket ITypedProtobuf<CMsgGCCStrike15_v2_ClientToGCRequestTicket>.Wrap(nint handle) => new CMsgGCCStrike15_v2_ClientToGCRequestTicketImpl(handle);


  public ulong AuthorizedSteamId { get; set; }


  public int AuthorizedPublicIp { get; set; }


  public ulong GameserverSteamId { get; set; }


  public string GameserverSdrRouting { get; set; }

}
