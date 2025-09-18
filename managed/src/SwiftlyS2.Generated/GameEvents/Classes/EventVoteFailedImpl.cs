using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "vote_failed"
/// </summary>
internal class EventVoteFailedImpl : GameEvent<EventVoteFailed>, EventVoteFailed
{


  public byte Team
  { get => (byte)Accessor.GetInt32("team"); set => Accessor.SetInt32("team", value); }
}
