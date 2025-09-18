
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsg_CVars : ITypedProtobuf<CMsg_CVars>
{
  static CMsg_CVars ITypedProtobuf<CMsg_CVars>.Wrap(nint handle) => new CMsg_CVarsImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CMsg_CVars_CVar> Cvars { get; }

}
