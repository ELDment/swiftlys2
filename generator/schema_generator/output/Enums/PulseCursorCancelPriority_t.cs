using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum PulseCursorCancelPriority_t : uint {

 None = 0,

 CancelOnSucceeded = 1,

 SoftCancel = 2,

 HardCancel = 3,
}