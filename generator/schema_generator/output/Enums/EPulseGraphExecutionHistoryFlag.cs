using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum EPulseGraphExecutionHistoryFlag : uint {

 NO_FLAGS = 0;
 CURSOR_ADD_TAG = 1;
 CURSOR_REMOVE_TAG = 2;
 CURSOR_RETIRED = 4;
 REQUIREMENT_PASS = 8;
 REQUIREMENT_FAIL = 16;
}