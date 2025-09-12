using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum TrainOrientationType_t : uint {

 TrainOrientation_Fixed = 0;
 TrainOrientation_AtPathTracks = 1;
 TrainOrientation_LinearBlend = 2;
 TrainOrientation_EaseInEaseOut = 3;
}