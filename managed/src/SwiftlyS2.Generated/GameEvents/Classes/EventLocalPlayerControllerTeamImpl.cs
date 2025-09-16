using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "local_player_controller_team"
/// </summary>
internal class EventLocalPlayerControllerTeamImpl : GameEvent<EventLocalPlayerControllerTeam>, EventLocalPlayerControllerTeam
{

  public EventLocalPlayerControllerTeamImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }
}
