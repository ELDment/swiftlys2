
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CGameInfo_CCSGameInfo : ITypedProtobuf<CGameInfo_CCSGameInfo>
{
  static CGameInfo_CCSGameInfo ITypedProtobuf<CGameInfo_CCSGameInfo>.Wrap(nint handle) => new CGameInfo_CCSGameInfoImpl(handle);


  public IProtobufRepeatedFieldValueType<int> RoundStartTicks { get; }

}
