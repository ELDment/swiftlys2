using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ParticleFloatMapType_t : uint {

 PF_MAP_TYPE_INVALID = uint.MaxValue,

 PF_MAP_TYPE_DIRECT = 0,

 PF_MAP_TYPE_MULT = 1,

 PF_MAP_TYPE_REMAP = 2,

 PF_MAP_TYPE_REMAP_BIASED = 3,

 PF_MAP_TYPE_CURVE = 4,

 PF_MAP_TYPE_NOTCHED = 5,

 PF_MAP_TYPE_ROUND = 6,

 PF_MAP_TYPE_COUNT = 7,
}