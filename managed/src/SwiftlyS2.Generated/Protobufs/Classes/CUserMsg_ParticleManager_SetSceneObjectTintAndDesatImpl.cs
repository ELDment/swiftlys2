
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CUserMsg_ParticleManager_SetSceneObjectTintAndDesatImpl : TypedProtobuf<CUserMsg_ParticleManager_SetSceneObjectTintAndDesat>, CUserMsg_ParticleManager_SetSceneObjectTintAndDesat
{
  public CUserMsg_ParticleManager_SetSceneObjectTintAndDesatImpl(nint handle): base(handle)
  {
  }


  public int Tint
  { get => Accessor.GetInt32("tint"); set => Accessor.SetInt32("tint", value); }


  public float Desat
  { get => Accessor.GetFloat("desat"); set => Accessor.SetFloat("desat", value); }

}
