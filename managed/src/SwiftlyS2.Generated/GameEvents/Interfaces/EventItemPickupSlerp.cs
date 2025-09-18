using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "item_pickup_slerp"
/// </summary>
public interface EventItemPickupSlerp : IGameEvent<EventItemPickupSlerp> {

  static EventItemPickupSlerp IGameEvent<EventItemPickupSlerp>.Create() => new EventItemPickupSlerpImpl();

  static string IGameEvent<EventItemPickupSlerp>.GetName() => "item_pickup_slerp";

  static uint IGameEvent<EventItemPickupSlerp>.GetHash() => 0x88B06F48u;
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
  short Index { get; set; }

  /// <summary>
  /// type: short
  /// </summary>
  short Behavior { get; set; }

}
