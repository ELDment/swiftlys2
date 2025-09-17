using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_replay_status"
/// </summary>
internal class EventHltvReplayStatusImpl : TypedGameEvent<EventHltvReplayStatus>, EventHltvReplayStatus
{


  // reason for hltv replay status change ()
  public int Reason
  { get => Accessor.GetInt32("reason"); set => Accessor.SetInt32("reason", value); }
}
