using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "cs_match_end_restart"
/// </summary>
internal class EventCsMatchEndRestartImpl : GameEvent<EventCsMatchEndRestart>, EventCsMatchEndRestart
{

  public EventCsMatchEndRestartImpl(nint address) : base(address)
  {
  }
}
