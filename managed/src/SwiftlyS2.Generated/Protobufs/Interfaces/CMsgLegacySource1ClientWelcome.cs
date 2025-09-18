
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgLegacySource1ClientWelcome : ITypedProtobuf<CMsgLegacySource1ClientWelcome>
{
  static CMsgLegacySource1ClientWelcome ITypedProtobuf<CMsgLegacySource1ClientWelcome>.Wrap(nint handle) => new CMsgLegacySource1ClientWelcomeImpl(handle);


  public uint Version { get; set; }


  public byte[] GameData { get; set; }


  public IProtobufRepeatedFieldSubMessageType<CMsgSOCacheSubscribed> OutofdateSubscribedCaches { get; }


  public IProtobufRepeatedFieldSubMessageType<CMsgSOCacheSubscriptionCheck> UptodateSubscribedCaches { get; }


  public CMsgLegacySource1ClientWelcome_Location Location { get; }


  public byte[] GameData2 { get; set; }


  public uint Rtime32GcWelcomeTimestamp { get; set; }


  public uint Currency { get; set; }


  public uint Balance { get; set; }


  public string BalanceUrl { get; set; }


  public string TxnCountryCode { get; set; }

}
