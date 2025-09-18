
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageRequestDllStatus : ITypedProtobuf<CUserMessageRequestDllStatus>, INetMessage<CUserMessageRequestDllStatus>
{
  static int INetMessage<CUserMessageRequestDllStatus>.MessageId => 156;
  
  static string INetMessage<CUserMessageRequestDllStatus>.MessageName => "CUserMessageRequestDllStatus";

  static CUserMessageRequestDllStatus ITypedProtobuf<CUserMessageRequestDllStatus>.Wrap(nint handle) => new CUserMessageRequestDllStatusImpl(handle);


  public string DllAction { get; set; }


  public bool FullReport { get; set; }

}
