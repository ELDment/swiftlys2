using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum VMixSubgraphSwitchInterpolationType_t : uint {

 SUBGRAPH_INTERPOLATION_TEMPORAL_CROSSFADE = 0,

 SUBGRAPH_INTERPOLATION_TEMPORAL_FADE_OUT = 1,

 SUBGRAPH_INTERPOLATION_KEEP_LAST_SUBGRAPH_RUNNING = 2,
}