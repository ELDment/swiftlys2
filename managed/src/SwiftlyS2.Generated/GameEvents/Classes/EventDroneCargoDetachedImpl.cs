using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "drone_cargo_detached"
/// </summary>
internal class EventDroneCargoDetachedImpl : GameEvent<EventDroneCargoDetached>, EventDroneCargoDetached
{

  public EventDroneCargoDetachedImpl(nint address) : base(address)
  {
  }

  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  public short Cargo
  { get => (short)Accessor.GetInt32("cargo"); set => Accessor.SetInt32("cargo", value); }

  public bool Delivered
  { get => Accessor.GetBool("delivered"); set => Accessor.SetBool("delivered", value); }
}
