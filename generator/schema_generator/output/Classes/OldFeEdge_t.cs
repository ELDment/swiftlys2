using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class OldFeEdge_t : SchemaClass, IOldFeEdge_t {

  public OldFeEdge_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<float> K {
    get => new SchemaFixedArray<float>(_Handle, 0xBAF074C17C12054C, 3, 4, 4);
  }
  public ref float InvA {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C1518D5F7B));
  }
  public ref float T {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C1F10C3DA3));
  }
  public ref float ThetaRelaxed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C14C35B770));
  }
  public ref float ThetaFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C165B8FFDA));
  }
  public ref float C01 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C13DE93555));
  }
  public ref float C02 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C13AE9309C));
  }
  public ref float C03 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C13BE9322F));
  }
  public ref float C04 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C138E92D76));
  }
  public ref float AxialModelDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBAF074C1E53980E9));
  }
  public ISchemaFixedArray<float> AxialModelWeights {
    get => new SchemaFixedArray<float>(_Handle, 0xBAF074C1D9CDB73E, 4, 4, 4);
  }
  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0xBAF074C1F6FB9B19, 4, 2, 2);
  }


}