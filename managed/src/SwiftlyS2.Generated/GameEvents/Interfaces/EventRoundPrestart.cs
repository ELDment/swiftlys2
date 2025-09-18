using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_prestart"
/// sent before all other round restart actions
/// </summary>
public interface EventRoundPrestart : IGameEvent<EventRoundPrestart> {

  static EventRoundPrestart IGameEvent<EventRoundPrestart>.Create() => new EventRoundPrestartImpl();

  static string IGameEvent<EventRoundPrestart>.GetName() => "round_prestart";

  static uint IGameEvent<EventRoundPrestart>.GetHash() => 0xE6A3E50Fu;
}
