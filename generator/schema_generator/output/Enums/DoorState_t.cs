using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum DoorState_t : uint {

 DOOR_STATE_CLOSED = 0,

 DOOR_STATE_OPENING = 1,

 DOOR_STATE_OPEN = 2,

 DOOR_STATE_CLOSING = 3,

 DOOR_STATE_AJAR = 4,
}