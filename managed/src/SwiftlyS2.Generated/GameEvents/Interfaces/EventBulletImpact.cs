using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "bullet_impact"
/// </summary>
public interface EventBulletImpact : IGameEvent<EventBulletImpact> {

  static EventBulletImpact IGameEvent<EventBulletImpact>.Create() => new EventBulletImpactImpl();

  static string IGameEvent<EventBulletImpact>.GetName() => "bullet_impact";

  static uint IGameEvent<EventBulletImpact>.GetHash() => 0x8B8FCCE8u;
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

}
