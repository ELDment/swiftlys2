using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum AnimLoopMode_t : uint {

 ANIM_LOOP_MODE_INVALID = uint.MaxValue;
 ANIM_LOOP_MODE_NOT_LOOPING = 0;
 ANIM_LOOP_MODE_LOOPING = 1;
 ANIM_LOOP_MODE_USE_SEQUENCE_SETTINGS = 2;
 ANIM_LOOP_MODE_COUNT = 3;
}