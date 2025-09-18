using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "survival_no_respawns_warning"
/// </summary>
public interface EventSurvivalNoRespawnsWarning : IGameEvent<EventSurvivalNoRespawnsWarning> {

  static EventSurvivalNoRespawnsWarning IGameEvent<EventSurvivalNoRespawnsWarning>.Create() => new EventSurvivalNoRespawnsWarningImpl();

  static string IGameEvent<EventSurvivalNoRespawnsWarning>.GetName() => "survival_no_respawns_warning";

  static uint IGameEvent<EventSurvivalNoRespawnsWarning>.GetHash() => 0xE1C858A2u;
  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller
  /// </summary>
  int UserId { get; set; }

}
