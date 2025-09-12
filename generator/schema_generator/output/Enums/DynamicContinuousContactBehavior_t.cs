using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum DynamicContinuousContactBehavior_t : byte {

 DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY = 0,

 DYNAMIC_CONTINUOUS_ALWAYS = 1,

 DYNAMIC_CONTINUOUS_NEVER = 2,
}