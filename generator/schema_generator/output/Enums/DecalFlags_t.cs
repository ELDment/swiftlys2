using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum DecalFlags_t : uint {

 eNone = 0;
 eCannotClear = 1;
 eAll = 4294967295;
 eAllButCannotClear = 4294967294;
}