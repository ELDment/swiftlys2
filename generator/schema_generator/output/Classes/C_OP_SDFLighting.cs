using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SDFLighting : CParticleFunctionOperator, IC_OP_SDFLighting {

  public C_OP_SDFLighting(nint handle) : base(handle) {
  }

  public ref Vector LightingDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDB0DD4D85DEEFA14));
  }
  public ref Vector Tint_0 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDB0DD4D83A60BBBF));
  }
  public ref Vector Tint_1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDB0DD4D83960BA2C));
  }


}