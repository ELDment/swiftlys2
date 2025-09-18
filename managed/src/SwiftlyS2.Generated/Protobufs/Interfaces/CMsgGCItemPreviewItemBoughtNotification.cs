
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCItemPreviewItemBoughtNotification : ITypedProtobuf<CMsgGCItemPreviewItemBoughtNotification>
{
  static CMsgGCItemPreviewItemBoughtNotification ITypedProtobuf<CMsgGCItemPreviewItemBoughtNotification>.Wrap(nint handle) => new CMsgGCItemPreviewItemBoughtNotificationImpl(handle);


  public uint ItemDefIndex { get; set; }

}
