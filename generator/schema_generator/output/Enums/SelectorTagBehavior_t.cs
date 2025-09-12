using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum SelectorTagBehavior_t : uint {

 SelectorTagBehavior_OnWhileCurrent = 0,

 SelectorTagBehavior_OffWhenFinished = 1,

 SelectorTagBehavior_OffBeforeFinished = 2,
}