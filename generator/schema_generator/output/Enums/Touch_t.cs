using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum Touch_t : uint {

 touch_none = 0,

 touch_player_only = 1,

 touch_npc_only = 2,

 touch_player_or_npc = 3,

 touch_player_or_npc_or_physicsprop = 4,
}