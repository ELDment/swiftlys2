using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "round_poststart"
/// sent after all other round restart actions
/// </summary>
internal class EventRoundPoststartImpl : GameEvent<EventRoundPoststart>, EventRoundPoststart
{

  public EventRoundPoststartImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }
}
