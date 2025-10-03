using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_pickup"
/// </summary>
internal class EventItemPickupImpl : GameEvent<EventItemPickup>, EventItemPickup
{

  public EventItemPickupImpl(nint address) : base(address)
  {
  }

  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  // either a weapon such as 'tmp' or 'hegrenade', or an item such as 'nvgs'
  public string Item
  { get => Accessor.GetString("item"); set => Accessor.SetString("item", value); }

  public bool Silent
  { get => Accessor.GetBool("silent"); set => Accessor.SetBool("silent", value); }

  public int DefIndex
  { get => Accessor.GetInt32("defindex"); set => Accessor.SetInt32("defindex", value); }
}
