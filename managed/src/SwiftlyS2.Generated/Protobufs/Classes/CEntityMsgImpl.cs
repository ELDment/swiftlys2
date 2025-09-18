
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CEntityMsgImpl : TypedProtobuf<CEntityMsg>, CEntityMsg
{
  public CEntityMsgImpl(nint handle): base(handle)
  {
  }


  public uint TargetEntity
  { get => Accessor.GetUInt32("target_entity"); set => Accessor.SetUInt32("target_entity", value); }

}
