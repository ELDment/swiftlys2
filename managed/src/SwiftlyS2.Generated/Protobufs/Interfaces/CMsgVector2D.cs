
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgVector2D : ITypedProtobuf<CMsgVector2D>
{
  static CMsgVector2D ITypedProtobuf<CMsgVector2D>.Wrap(nint handle) => new CMsgVector2DImpl(handle);


  public float X { get; set; }


  public float Y { get; set; }

}
