using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_zoom"
/// </summary>
public interface EventWeaponZoom : IGameEvent<EventWeaponZoom> {

  static EventWeaponZoom IGameEvent<EventWeaponZoom>.Create() => new EventWeaponZoomImpl();

  static string IGameEvent<EventWeaponZoom>.GetName() => "weapon_zoom";

  static uint IGameEvent<EventWeaponZoom>.GetHash() => 0xBF1A06E1u;
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

}
