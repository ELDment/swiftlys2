using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum PulseCursorExecResult_t : uint {

 Succeeded = 0,

 Canceled = 1,

 Failed = 2,

 OngoingNotify = 3,
}