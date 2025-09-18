
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_AccountPrivacySettings_Setting : ITypedProtobuf<CMsgGCCStrike15_v2_AccountPrivacySettings_Setting>
{
  static CMsgGCCStrike15_v2_AccountPrivacySettings_Setting ITypedProtobuf<CMsgGCCStrike15_v2_AccountPrivacySettings_Setting>.Wrap(nint handle) => new CMsgGCCStrike15_v2_AccountPrivacySettings_SettingImpl(handle);


  public uint SettingType { get; set; }


  public uint SettingValue { get; set; }

}
