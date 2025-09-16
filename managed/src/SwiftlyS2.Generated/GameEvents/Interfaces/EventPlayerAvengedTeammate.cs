using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_avenged_teammate"
/// </summary>
public interface EventPlayerAvengedTeammate : IGameEvent<EventPlayerAvengedTeammate> {

  static EventPlayerAvengedTeammate IGameEvent<EventPlayerAvengedTeammate>.FromAllocated(nint ptr) => new EventPlayerAvengedTeammateImpl(ptr, true);

  static EventPlayerAvengedTeammate IGameEvent<EventPlayerAvengedTeammate>.FromExternal(nint ptr) => new EventPlayerAvengedTeammateImpl(ptr, false);

  static string IGameEvent<EventPlayerAvengedTeammate>.GetName() => "player_avenged_teammate";

  static uint IGameEvent<EventPlayerAvengedTeammate>.GetHash() => 0x8E286DACu;
  /// <summary>
  /// type: player_controller
  /// </summary>
  int AvengerId { get; set; }

  /// <summary>
  /// type: player_controller
  /// </summary>
  int AvengedPlayerId { get; set; }

}
