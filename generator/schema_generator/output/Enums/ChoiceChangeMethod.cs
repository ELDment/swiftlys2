using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum ChoiceChangeMethod : uint {

 OnReset = 0,

 OnCycleEnd = 1,

 OnResetOrCycleEnd = 2,
}