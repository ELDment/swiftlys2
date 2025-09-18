using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "weapon_fire_on_empty"
/// </summary>
public interface EventWeaponFireOnEmpty : IGameEvent<EventWeaponFireOnEmpty> {

  static EventWeaponFireOnEmpty IGameEvent<EventWeaponFireOnEmpty>.Create() => new EventWeaponFireOnEmptyImpl();

  static string IGameEvent<EventWeaponFireOnEmpty>.GetName() => "weapon_fire_on_empty";

  static uint IGameEvent<EventWeaponFireOnEmpty>.GetHash() => 0xB2954170u;
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
  /// weapon name used
  /// <br/>
  /// type: string
  /// </summary>
  string Weapon { get; set; }

}
