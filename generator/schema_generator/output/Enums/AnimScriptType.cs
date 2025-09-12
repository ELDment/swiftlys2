using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum AnimScriptType : ushort {

 ANIMSCRIPT_TYPE_INVALID = ushort.MaxValue,

 ANIMSCRIPT_FUSE_GENERAL = 0,

 ANIMSCRIPT_FUSE_STATEMACHINE = 1,
}