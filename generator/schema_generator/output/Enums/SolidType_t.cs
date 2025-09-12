using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum SolidType_t : byte {

 SOLID_NONE = 0;
 SOLID_BSP = 1;
 SOLID_BBOX = 2;
 SOLID_OBB = 3;
 SOLID_SPHERE = 4;
 SOLID_POINT = 5;
 SOLID_VPHYSICS = 6;
 SOLID_CAPSULE = 7;
 SOLID_LAST = 8;
}