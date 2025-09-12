using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum TrainVelocityType_t : uint {

 TrainVelocity_Instantaneous = 0;
 TrainVelocity_LinearBlend = 1;
 TrainVelocity_EaseInEaseOut = 2;
}