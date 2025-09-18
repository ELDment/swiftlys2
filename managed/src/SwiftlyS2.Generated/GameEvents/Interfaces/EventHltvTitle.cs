using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "hltv_title"
/// </summary>
public interface EventHltvTitle : IGameEvent<EventHltvTitle> {

  static EventHltvTitle IGameEvent<EventHltvTitle>.Create() => new EventHltvTitleImpl();

  static string IGameEvent<EventHltvTitle>.GetName() => "hltv_title";

  static uint IGameEvent<EventHltvTitle>.GetHash() => 0xA9B9262Au;
  /// <summary>
  /// type: string
  /// </summary>
  string Text { get; set; }

}
