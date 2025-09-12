using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum VelocityMetricMode : byte {

 DirectionOnly = 0;
 MagnitudeOnly = 1;
 DirectionAndMagnitude = 2;
}