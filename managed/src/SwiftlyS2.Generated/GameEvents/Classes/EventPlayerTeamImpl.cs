using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "player_team"
/// </summary>
internal class EventPlayerTeamImpl : GameEvent<EventPlayerTeam>, EventPlayerTeam
{


  public CCSPlayerController UserIdController
  { get => Accessor.GetPlayerController("userid"); }

  public CCSPlayerPawn UserIdPawn
  { get => Accessor.GetPlayerPawn("userid"); }

  public int UserId
  { get => Accessor.GetInt32("userid"); set => Accessor.SetInt32("userid", value); }

  // team id
  public byte Team
  { get => (byte)Accessor.GetInt32("team"); set => Accessor.SetInt32("team", value); }

  // old team id
  public byte OldTeam
  { get => (byte)Accessor.GetInt32("oldteam"); set => Accessor.SetInt32("oldteam", value); }

  // team change because player disconnects
  public bool Disconnect
  { get => Accessor.GetBool("disconnect"); set => Accessor.SetBool("disconnect", value); }

  public bool Silent
  { get => Accessor.GetBool("silent"); set => Accessor.SetBool("silent", value); }

  public string Name
  { get => Accessor.GetString("name"); set => Accessor.SetString("name", value); }

  public bool IsBot
  { get => Accessor.GetBool("isbot"); set => Accessor.SetBool("isbot", value); }
}
