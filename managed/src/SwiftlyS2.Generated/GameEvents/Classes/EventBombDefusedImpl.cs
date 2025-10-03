using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "bomb_defused"
/// </summary>
internal class EventBombDefusedImpl : GameEvent<EventBombDefused>, EventBombDefused
{

  public EventBombDefusedImpl(nint address) : base(address)
  {
  }

  // player who defused the bomb
  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  // player who defused the bomb
  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  // player who defused the bomb
  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  // bombsite index
  public short Site
  { get => (short)Accessor.GetInt32("site"); set => Accessor.SetInt32("site", value); }
}
