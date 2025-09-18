
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgTEBloodStreamImpl : NetMessage<CMsgTEBloodStream>, CMsgTEBloodStream
{
  public CMsgTEBloodStreamImpl(nint handle): base(handle)
  {
  }


  public Vector Origin
  { get => Accessor.GetVector("origin"); set => Accessor.SetVector("origin", value); }


  public Vector Direction
  { get => Accessor.GetVector("direction"); set => Accessor.SetVector("direction", value); }


  public int Color
  { get => Accessor.GetInt32("color"); set => Accessor.SetInt32("color", value); }


  public uint Amount
  { get => Accessor.GetUInt32("amount"); set => Accessor.SetUInt32("amount", value); }

}
