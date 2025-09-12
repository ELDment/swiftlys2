using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ParticleEndcapMode_t : uint {

 PARTICLE_ENDCAP_ALWAYS_ON = uint.MaxValue;
 PARTICLE_ENDCAP_ENDCAP_OFF = 0;
 PARTICLE_ENDCAP_ENDCAP_ON = 1;
}