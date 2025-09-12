using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum MoveCollide_t : byte {

 MOVECOLLIDE_DEFAULT = 0,

 MOVECOLLIDE_FLY_BOUNCE = 1,

 MOVECOLLIDE_FLY_CUSTOM = 2,

 MOVECOLLIDE_FLY_SLIDE = 3,

 MOVECOLLIDE_COUNT = 4,

 MOVECOLLIDE_MAX_BITS = 3,
}