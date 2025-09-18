
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgApplyPennantUpgrade : ITypedProtobuf<CMsgApplyPennantUpgrade>
{
  static CMsgApplyPennantUpgrade ITypedProtobuf<CMsgApplyPennantUpgrade>.Wrap(nint handle) => new CMsgApplyPennantUpgradeImpl(handle);


  public ulong UpgradeItemId { get; set; }


  public ulong PennantItemId { get; set; }

}
