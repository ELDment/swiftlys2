using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapCPtoScalar : CParticleFunctionInitializer, IC_INIT_RemapCPtoScalar {

  public C_INIT_RemapCPtoScalar(nint handle) : base(handle) {
  }

  public C_INIT_RemapCPtoScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2D235A05FB805736));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2D235A05E5729606));
  }
  public ref int Field {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2D235A05C257B93B));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A05E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A05D6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A055F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A0551A0E8C4));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A0567FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A052041DF9D));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x2D235A05FB53C31E));
  }
  public ref float RemapBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D235A05490D7325));
  }


}