using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NmCompressionSettings_t__QuantizationRange_t : SchemaClass, INmCompressionSettings_t__QuantizationRange_t {

  public NmCompressionSettings_t__QuantizationRange_t(nint handle) : base(handle) {
  }

  public ref float RangeStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA662A641F7D21E68));
  }
  public ref float RangeLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA662A6418C3501A8));
  }


}