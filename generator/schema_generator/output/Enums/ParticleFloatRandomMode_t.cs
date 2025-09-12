using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ParticleFloatRandomMode_t : uint {

 PF_RANDOM_MODE_INVALID = uint.MaxValue,

 PF_RANDOM_MODE_CONSTANT = 0,

 PF_RANDOM_MODE_VARYING = 1,

 PF_RANDOM_MODE_COUNT = 2,
}