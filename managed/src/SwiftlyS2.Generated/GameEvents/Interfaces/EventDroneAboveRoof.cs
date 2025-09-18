using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "drone_above_roof"
/// </summary>
public interface EventDroneAboveRoof : IGameEvent<EventDroneAboveRoof> {

  static EventDroneAboveRoof IGameEvent<EventDroneAboveRoof>.Create() => new EventDroneAboveRoofImpl();

  static string IGameEvent<EventDroneAboveRoof>.GetName() => "drone_above_roof";

  static uint IGameEvent<EventDroneAboveRoof>.GetHash() => 0x647D7762u;
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

  /// <summary>
  /// type: short
  /// </summary>
  short Cargo { get; set; }

}
