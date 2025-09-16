using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "nav_blocked"
/// </summary>
internal class EventNavBlockedImpl : GameEvent<EventNavBlocked>, EventNavBlocked
{

  public EventNavBlockedImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  public int Area
  { get => GetInt("area"); set => SetInt("area", value); }

  public bool Blocked
  { get => GetBool("blocked"); set => SetBool("blocked", value); }
}
