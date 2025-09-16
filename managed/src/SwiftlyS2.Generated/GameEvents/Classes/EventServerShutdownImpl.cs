using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "server_shutdown"
/// server shut down
/// </summary>
internal class EventServerShutdownImpl : GameEvent<EventServerShutdown>, EventServerShutdown
{

  public EventServerShutdownImpl(nint handle, bool isManuallyAllocated) : base(handle, isManuallyAllocated)
  {
  }

  // reason why server was shut down
  public string Reason
  { get => GetString("reason"); set => SetString("reason", value); }
}
