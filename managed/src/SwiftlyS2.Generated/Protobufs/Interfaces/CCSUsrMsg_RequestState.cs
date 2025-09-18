
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_RequestState : ITypedProtobuf<CCSUsrMsg_RequestState>, INetMessage<CCSUsrMsg_RequestState>
{
  static int INetMessage<CCSUsrMsg_RequestState>.MessageId => 320;
  
  static string INetMessage<CCSUsrMsg_RequestState>.MessageName => "CCSUsrMsg_RequestState";

  static CCSUsrMsg_RequestState ITypedProtobuf<CCSUsrMsg_RequestState>.Wrap(nint handle) => new CCSUsrMsg_RequestStateImpl(handle);


  public int Dummy { get; set; }

}
