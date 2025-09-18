
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSubtickMoveStep : ITypedProtobuf<CSubtickMoveStep>
{
  static CSubtickMoveStep ITypedProtobuf<CSubtickMoveStep>.Wrap(nint handle) => new CSubtickMoveStepImpl(handle);


  public ulong Button { get; set; }


  public bool Pressed { get; set; }


  public float When { get; set; }


  public float AnalogForwardDelta { get; set; }


  public float AnalogLeftDelta { get; set; }


  public float AnalogPitchDelta { get; set; }


  public float AnalogYawDelta { get; set; }

}
