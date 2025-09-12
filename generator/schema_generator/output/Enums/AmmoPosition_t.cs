using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum AmmoPosition_t : uint {

 AMMO_POSITION_INVALID = uint.MaxValue;
 AMMO_POSITION_PRIMARY = 0;
 AMMO_POSITION_SECONDARY = 1;
 AMMO_POSITION_COUNT = 2;
}