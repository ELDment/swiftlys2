using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "add_bullet_hit_marker"
/// </summary>
internal class EventAddBulletHitMarkerImpl : GameEvent<EventAddBulletHitMarker>, EventAddBulletHitMarker
{

  public EventAddBulletHitMarkerImpl(nint address) : base(address)
  {
  }

  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  public short Bone
  { get => (short)Accessor.GetInt32("bone"); set => Accessor.SetInt32("bone", value); }

  public short PosX
  { get => (short)Accessor.GetInt32("pos_x"); set => Accessor.SetInt32("pos_x", value); }

  public short PosY
  { get => (short)Accessor.GetInt32("pos_y"); set => Accessor.SetInt32("pos_y", value); }

  public short PosZ
  { get => (short)Accessor.GetInt32("pos_z"); set => Accessor.SetInt32("pos_z", value); }

  public short AngX
  { get => (short)Accessor.GetInt32("ang_x"); set => Accessor.SetInt32("ang_x", value); }

  public short AngY
  { get => (short)Accessor.GetInt32("ang_y"); set => Accessor.SetInt32("ang_y", value); }

  public short AngZ
  { get => (short)Accessor.GetInt32("ang_z"); set => Accessor.SetInt32("ang_z", value); }

  public short StartX
  { get => (short)Accessor.GetInt32("start_x"); set => Accessor.SetInt32("start_x", value); }

  public short StartY
  { get => (short)Accessor.GetInt32("start_y"); set => Accessor.SetInt32("start_y", value); }

  public short StartZ
  { get => (short)Accessor.GetInt32("start_z"); set => Accessor.SetInt32("start_z", value); }

  public bool Hit
  { get => Accessor.GetBool("hit"); set => Accessor.SetBool("hit", value); }
}
