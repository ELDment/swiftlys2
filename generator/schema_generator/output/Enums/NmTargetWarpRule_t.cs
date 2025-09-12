using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum NmTargetWarpRule_t : byte {

 WarpXY = 0;
 WarpZ = 1;
 WarpXYZ = 2;
 RotationOnly = 3;
}