using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum FacingMode : byte {

 FacingMode_Invalid = 0;
 FacingMode_Manual = 1;
 FacingMode_Path = 2;
 FacingMode_LookTarget = 3;
 FacingMode_ManualPosition = 4;
}