using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum BoneMaskBlendSpace : uint {

 BlendSpace_Parent = 0,

 BlendSpace_Model = 1,

 BlendSpace_Model_RotationOnly = 2,

 BlendSpace_Model_TranslationOnly = 3,
}