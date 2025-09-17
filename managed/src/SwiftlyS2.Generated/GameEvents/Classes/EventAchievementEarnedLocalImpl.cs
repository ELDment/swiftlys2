using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "achievement_earned_local"
/// </summary>
internal class EventAchievementEarnedLocalImpl : TypedGameEvent<EventAchievementEarnedLocal>, EventAchievementEarnedLocal
{


  // achievement ID
  public short Achievement
  { get => (short)Accessor.GetInt32("achievement"); set => Accessor.SetInt32("achievement", value); }

  // splitscreen ID
  public short SplitScreenPlayer
  { get => (short)Accessor.GetInt32("splitscreenplayer"); set => Accessor.SetInt32("splitscreenplayer", value); }
}
