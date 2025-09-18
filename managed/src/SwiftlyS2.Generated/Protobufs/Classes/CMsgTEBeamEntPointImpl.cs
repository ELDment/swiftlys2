
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgTEBeamEntPointImpl : NetMessage<CMsgTEBeamEntPoint>, CMsgTEBeamEntPoint
{
  public CMsgTEBeamEntPointImpl(nint handle): base(handle)
  {
  }


  public CMsgTEBaseBeam Base
  { get => new CMsgTEBaseBeamImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "base")); }


  public uint Startentity
  { get => Accessor.GetUInt32("startentity"); set => Accessor.SetUInt32("startentity", value); }


  public uint Endentity
  { get => Accessor.GetUInt32("endentity"); set => Accessor.SetUInt32("endentity", value); }


  public Vector Start
  { get => Accessor.GetVector("start"); set => Accessor.SetVector("start", value); }


  public Vector End
  { get => Accessor.GetVector("end"); set => Accessor.SetVector("end", value); }

}
