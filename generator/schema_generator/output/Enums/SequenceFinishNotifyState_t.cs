using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum SequenceFinishNotifyState_t : byte {

 eDoNotNotify = 0,

 eNotifyWhenFinished = 1,

 eNotifyTriggered = 2,
}