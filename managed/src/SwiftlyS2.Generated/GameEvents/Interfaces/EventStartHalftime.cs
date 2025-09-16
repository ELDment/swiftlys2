using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "start_halftime"
/// </summary>
public interface EventStartHalftime : IGameEvent<EventStartHalftime> {

  static EventStartHalftime IGameEvent<EventStartHalftime>.FromAllocated(nint ptr) => new EventStartHalftimeImpl(ptr, true);

  static EventStartHalftime IGameEvent<EventStartHalftime>.FromExternal(nint ptr) => new EventStartHalftimeImpl(ptr, false);

  static string IGameEvent<EventStartHalftime>.GetName() => "start_halftime";

  static uint IGameEvent<EventStartHalftime>.GetHash() => 0xC0794EE0u;
}
