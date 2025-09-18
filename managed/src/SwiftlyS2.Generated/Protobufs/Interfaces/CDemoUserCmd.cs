
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoUserCmd : ITypedProtobuf<CDemoUserCmd>
{
  static CDemoUserCmd ITypedProtobuf<CDemoUserCmd>.Wrap(nint handle) => new CDemoUserCmdImpl(handle);


  public int CmdNumber { get; set; }


  public byte[] Data { get; set; }

}
