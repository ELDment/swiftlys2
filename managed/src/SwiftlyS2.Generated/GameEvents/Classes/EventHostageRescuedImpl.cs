using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hostage_rescued"
/// </summary>
internal class EventHostageRescuedImpl : GameEvent<EventHostageRescued>, EventHostageRescued
{

  public EventHostageRescuedImpl(nint address) : base(address)
  {
  }

  // player who rescued the hostage
  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  // player who rescued the hostage
  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  // player who rescued the hostage
  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  // hostage entity index
  public short Hostage
  { get => (short)Accessor.GetInt32("hostage"); set => Accessor.SetInt32("hostage", value); }

  // rescue site index
  public short Site
  { get => (short)Accessor.GetInt32("site"); set => Accessor.SetInt32("site", value); }
}
