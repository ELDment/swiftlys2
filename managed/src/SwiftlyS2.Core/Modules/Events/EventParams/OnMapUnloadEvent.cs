using SwiftlyS2.Shared.Events;

namespace SwiftlyS2.Core.Events;

internal class OnMapUnloadEvent : IOnMapUnloadEvent
{

  public required string MapName { get; set; }
} 