
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CCommunity_TerminateGamePersonalDataEntries_Response : ITypedProtobuf<CCommunity_TerminateGamePersonalDataEntries_Response>
{
  static CCommunity_TerminateGamePersonalDataEntries_Response ITypedProtobuf<CCommunity_TerminateGamePersonalDataEntries_Response>.Wrap(nint handle) => new CCommunity_TerminateGamePersonalDataEntries_ResponseImpl(handle);


  public uint Gceresult { get; set; }

}
