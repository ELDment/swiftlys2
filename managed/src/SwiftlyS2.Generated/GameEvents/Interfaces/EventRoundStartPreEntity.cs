using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "round_start_pre_entity"
/// </summary>
public interface EventRoundStartPreEntity : IGameEvent<EventRoundStartPreEntity> {

  static EventRoundStartPreEntity IGameEvent<EventRoundStartPreEntity>.FromAllocated(nint ptr) => new EventRoundStartPreEntityImpl(ptr, true);

  static EventRoundStartPreEntity IGameEvent<EventRoundStartPreEntity>.FromExternal(nint ptr) => new EventRoundStartPreEntityImpl(ptr, false);

  static string IGameEvent<EventRoundStartPreEntity>.GetName() => "round_start_pre_entity";

  static uint IGameEvent<EventRoundStartPreEntity>.GetHash() => 0x703715ECu;
}
