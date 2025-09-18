using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_radio"
/// </summary>
public interface EventPlayerRadio : IGameEvent<EventPlayerRadio> {

  static EventPlayerRadio IGameEvent<EventPlayerRadio>.Create() => new EventPlayerRadioImpl();

  static string IGameEvent<EventPlayerRadio>.GetName() => "player_radio";

  static uint IGameEvent<EventPlayerRadio>.GetHash() => 0x133AAE2Cu;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserIdController { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerPawn UserIdPawn { get; }

  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  int UserId { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Slot { get; set; }

}
