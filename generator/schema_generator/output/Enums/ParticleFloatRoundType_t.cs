using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ParticleFloatRoundType_t : uint {

 PF_ROUND_TYPE_INVALID = uint.MaxValue,

 PF_ROUND_TYPE_NEAREST = 0,

 PF_ROUND_TYPE_FLOOR = 1,

 PF_ROUND_TYPE_CEIL = 2,

 PF_ROUND_TYPE_COUNT = 3,
}