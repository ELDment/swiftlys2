using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ScriptedHeldWeaponBehavior_t : uint {

 eInvalid = uint.MaxValue;
 eHolster = 0;
 eDeploy = 1;
 eDrop = 2;
}