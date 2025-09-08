using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DistanceBetweenCPsToCP : CParticleFunctionPreEmission, IC_OP_DistanceBetweenCPsToCP {

  public C_OP_DistanceBetweenCPsToCP(nint handle) : base(handle) {
  }

  public ref int StartCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x379849D82C2FF970));
  }
  public ref int EndCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x379849D88C9B426D));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x379849D850DF5703));
  }
  public ref int OutputCPField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x379849D86F275D5D));
  }
  public ref bool SetOnce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x379849D86B261086));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x379849D8E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x379849D8D6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x379849D85F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x379849D851A0E8C4));
  }
  public ref float MaxTraceLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x379849D8543C3798));
  }
  public ref float LOSScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x379849D8259F6F3B));
  }
  public ref bool LOS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x379849D89C25C2ED));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle, 0x379849D8D58A3195, 128, 1, 1);
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0x379849D8BD26C5B2));
  }
  public ref ParticleParentSetMode_t SetParent {
    get => ref _Handle.AsRef<ParticleParentSetMode_t>(Schema.GetOffset(0x379849D82D8246B7));
  }


}