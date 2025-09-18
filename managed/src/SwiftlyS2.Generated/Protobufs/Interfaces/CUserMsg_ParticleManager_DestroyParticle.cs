
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMsg_ParticleManager_DestroyParticle : ITypedProtobuf<CUserMsg_ParticleManager_DestroyParticle>
{
  static CUserMsg_ParticleManager_DestroyParticle ITypedProtobuf<CUserMsg_ParticleManager_DestroyParticle>.Wrap(nint handle) => new CUserMsg_ParticleManager_DestroyParticleImpl(handle);


  public bool DestroyImmediately { get; set; }

}
