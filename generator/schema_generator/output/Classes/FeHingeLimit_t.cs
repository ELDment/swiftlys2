using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeHingeLimit_t : SchemaClass, IFeHingeLimit_t {

  public FeHingeLimit_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0x3E7F1FF5CD6694B9, 6, 2, 2);
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x3E7F1FF5B8D52E48));
  }
  public ref float Weight4 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3E7F1FF56956236D));
  }
  public ref float Weight5 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3E7F1FF5685621DA));
  }
  public ref float AngleCenter {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3E7F1FF57BF2D76B));
  }
  public ref float AngleExtents {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3E7F1FF59D58EF0B));
  }


}