using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum CDebugOverlayFilterType_t : uint {

 NONE = 0;
 TEXT = 1;
 ENTITY = 2;
 COUNT = 3;
 TACTICAL_SEARCH = 4;
 AI_SCHEDULE = 5;
 AI_TASK = 6;
 AI_EVENT = 7;
 AI_PATHFINDING = 8;
 END_SIM_HISTORY_TYPES = 9;
 COMBINED = uint.MaxValue;
}