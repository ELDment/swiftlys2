using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum EntitySubclassScope_t : uint {

 SUBCLASS_SCOPE_NONE = uint.MaxValue;
 SUBCLASS_SCOPE_PRECIPITATION = 0;
 SUBCLASS_SCOPE_PLAYER_WEAPONS = 1;
 SUBCLASS_SCOPE_COUNT = 2;
}