using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ParticleFloatInputMode_t : uint {

 PF_INPUT_MODE_INVALID = uint.MaxValue,

 PF_INPUT_MODE_CLAMPED = 0,

 PF_INPUT_MODE_LOOPED = 1,

 PF_INPUT_MODE_COUNT = 2,
}