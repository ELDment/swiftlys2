using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SampleCode : SchemaClass, ISampleCode {

  public SampleCode(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<byte> SubCode {
    get => new SchemaFixedArray<byte>(_Handle, 0x6387E3865AD6C244, 8, 1, 1);
  }


}