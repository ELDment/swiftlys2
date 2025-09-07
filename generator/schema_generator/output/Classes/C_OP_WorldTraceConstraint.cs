using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_WorldTraceConstraint : CParticleFunctionConstraint, IC_OP_WorldTraceConstraint {

  public C_OP_WorldTraceConstraint(nint handle) : base(handle) {
  }

  public C_OP_WorldTraceConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD88A859FEB661472));
  }
  public ref Vector CpOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD88A859FA3985361));
  }
  public ref ParticleCollisionMode_t CollisionMode {
    get => ref _Handle.AsRef<ParticleCollisionMode_t>(Schema.GetOffset(0xD88A859F2EB03DC4));
  }
  public ref ParticleCollisionMode_t CollisionModeMin {
    get => ref _Handle.AsRef<ParticleCollisionMode_t>(Schema.GetOffset(0xD88A859F6BF73D98));
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0xD88A859FBD26C5B2));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xD88A859FD58A3195));
  }
  public ref bool WorldOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD88A859FC03ED30D));
  }
  public ref bool BrushOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD88A859F66F92BAD));
  }
  public ref bool IncludeWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD88A859FEB8D4646));
  }
  public ref int IgnoreCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD88A859FF0DDC7AC));
  }
  public ref float CpMovementTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD88A859FC12044AC));
  }
  public ref float RetestRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD88A859F38DA66AC));
  }
  public ref float TraceTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD88A859F8AA4F663));
  }
  public ref float CollisionConfirmationSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD88A859F18CD4FE3));
  }
  public ref float MaxTracesPerFrame {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD88A859F849E53A7));
  }
  public IPerParticleFloatInput RadiusScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD88A859FA7A20159));
  }
  public IPerParticleFloatInput BounceAmount {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD88A859F43A3ECA3));
  }
  public IPerParticleFloatInput SlideAmount {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD88A859F674011EC));
  }
  public IPerParticleFloatInput RandomDirScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD88A859FDAE4B057));
  }
  public ref bool DecayBounce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD88A859FC161B795));
  }
  public ref bool KillonContact {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD88A859FDB24D138));
  }
  public ref float MinSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD88A859F4A4CBC54));
  }
  public ref bool SetNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD88A859F542722AC));
  }
  public IParticleAttributeIndex_t StickOnCollisionField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD88A859FA94734FA));
  }
  public IPerParticleFloatInput StopSpeed {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD88A859FC6DE3582));
  }
  public IParticleAttributeIndex_t EntityStickDataField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD88A859F9BA1B8FA));
  }
  public IParticleAttributeIndex_t EntityStickNormalField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD88A859FBB3D8ECF));
  }


}