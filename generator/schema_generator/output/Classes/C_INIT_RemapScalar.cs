using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapScalar : CParticleFunctionInitializer, IC_INIT_RemapScalar {

  public C_INIT_RemapScalar(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x81ECA0CBAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x81ECA0CBE5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CBE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CBD6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CB5F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CB51A0E8C4));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CB67FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CB2041DF9D));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x81ECA0CBFB53C31E));
  }
  public ref bool ActiveRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81ECA0CB3FA53B84));
  }
  public ref float RemapBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81ECA0CB490D7325));
  }


}