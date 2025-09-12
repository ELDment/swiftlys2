using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum StanceType_t : uint {

 STANCE_CURRENT = uint.MaxValue,

 STANCE_DEFAULT = 0,

 STANCE_CROUCHING = 1,

 STANCE_PRONE = 2,

 NUM_STANCES = 3,
}