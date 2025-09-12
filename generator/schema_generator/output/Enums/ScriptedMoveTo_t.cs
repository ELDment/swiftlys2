using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ScriptedMoveTo_t : uint {

 eWait = 0;
 eMoveWithGait = 3;
 eTeleport = 4;
 eWaitFacing = 5;
 eObsoleteBackCompat1 = 1;
 eObsoleteBackCompat2 = 2;
}