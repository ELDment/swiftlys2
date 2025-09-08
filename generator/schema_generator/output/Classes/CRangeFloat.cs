using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRangeFloat : SchemaClass, IRangeFloat {

  public CRangeFloat(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<float> Value {
    get => new SchemaFixedArray<float>(_Handle, 0xD3CD83EB7F437844, 2, 4, 4);
  }


}