using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "set_instructor_group_enabled"
/// </summary>
internal class EventSetInstructorGroupEnabledImpl : TypedGameEvent<EventSetInstructorGroupEnabled>, EventSetInstructorGroupEnabled
{

  public EventSetInstructorGroupEnabledImpl(IGameEvent accessor) : base(accessor)
  {
  }

  public string Group
  { get => Accessor.GetString("group"); set => Accessor.SetString("group", value); }

  public short Enabled
  { get => (short)Accessor.GetInt32("enabled"); set => Accessor.SetInt32("enabled", value); }
}
