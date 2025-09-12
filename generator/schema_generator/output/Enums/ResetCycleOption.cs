using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ResetCycleOption : uint {

 Beginning = 0,

 SameCycleAsSource = 1,

 InverseSourceCycle = 2,

 FixedValue = 3,

 SameTimeAsSource = 4,
}