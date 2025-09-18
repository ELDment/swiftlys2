
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMsg_ParticleManager_UpdateParticle_OBSOLETE : ITypedProtobuf<CUserMsg_ParticleManager_UpdateParticle_OBSOLETE>
{
  static CUserMsg_ParticleManager_UpdateParticle_OBSOLETE ITypedProtobuf<CUserMsg_ParticleManager_UpdateParticle_OBSOLETE>.Wrap(nint handle) => new CUserMsg_ParticleManager_UpdateParticle_OBSOLETEImpl(handle);


  public int ControlPoint { get; set; }


  public Vector Position { get; set; }

}
