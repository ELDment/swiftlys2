using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "smoke_beacon_paradrop"
/// </summary>
internal class EventSmokeBeaconParadropImpl : GameEvent<EventSmokeBeaconParadrop>, EventSmokeBeaconParadrop
{

  public EventSmokeBeaconParadropImpl(nint address) : base(address)
  {
  }

  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  public short ParaDrop
  { get => (short)Accessor.GetInt32("paradrop"); set => Accessor.SetInt32("paradrop", value); }
}
