using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_ping_stop"
/// </summary>
internal class EventPlayerPingStopImpl : GameEvent<EventPlayerPingStop>, EventPlayerPingStop
{


  public short EntityID
  { get => (short)Accessor.GetInt32("entityid"); set => Accessor.SetInt32("entityid", value); }
}
