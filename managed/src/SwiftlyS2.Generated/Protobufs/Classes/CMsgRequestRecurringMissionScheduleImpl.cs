
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgRequestRecurringMissionScheduleImpl : TypedProtobuf<CMsgRequestRecurringMissionSchedule>, CMsgRequestRecurringMissionSchedule
{
  public CMsgRequestRecurringMissionScheduleImpl(nint handle): base(handle)
  {
  }


}
