using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "item_pickup_failed"
/// </summary>
internal class EventItemPickupFailedImpl : GameEvent<EventItemPickupFailed>, EventItemPickupFailed
{


  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  public string Item
  { get => Accessor.GetString("item"); set => Accessor.SetString("item", value); }

  public short Reason
  { get => (short)Accessor.GetInt32("reason"); set => Accessor.SetInt32("reason", value); }

  public short Limit
  { get => (short)Accessor.GetInt32("limit"); set => Accessor.SetInt32("limit", value); }
}
