using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "player_ping"
/// </summary>
public interface EventPlayerPing : IGameEvent<EventPlayerPing> {

  static EventPlayerPing IGameEvent<EventPlayerPing>.FromAllocated(nint ptr) => new EventPlayerPingImpl(ptr, true);

  static EventPlayerPing IGameEvent<EventPlayerPing>.FromExternal(nint ptr) => new EventPlayerPingImpl(ptr, false);

  static string IGameEvent<EventPlayerPing>.GetName() => "player_ping";

  static uint IGameEvent<EventPlayerPing>.GetHash() => 0xB41F45B1u;
  /// <summary>
  /// <br/>
  /// type: player_controller_and_pawn
  /// </summary>
  CCSPlayerController UserId { get; }

  /// <summary>
  /// type: short
  /// </summary>
  short EntityID { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float X { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Y { get; set; }

  /// <summary>
  /// type: float
  /// </summary>
  float Z { get; set; }

  /// <summary>
  /// type: bool
  /// </summary>
  bool Urgent { get; set; }

}
