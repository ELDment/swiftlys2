using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnBodyDesc_t : SchemaClass, IRnBodyDesc_t {

  public RnBodyDesc_t(nint handle) : base(handle) {
  }

  public ref CUtlString DebugName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB8BC96379D265F86));
  }
  public ref Vector Position {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC9637BD6A6C9E));
  }
  public ref QuaternionStorage Orientation {
    get => ref _Handle.AsRef<QuaternionStorage>(Schema.GetOffset(0xB8BC9637B94C5DF6));
  }
  public ref Vector LinearVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC963756422B27));
  }
  public ref Vector AngularVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC96378ACE7A12));
  }
  public ref Vector LocalMassCenter {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC9637AFDB4EDD));
  }
  public ISchemaFixedArray<Vector> LocalInertiaInv {
    get => new SchemaFixedArray<Vector>(_Handle, 0xB8BC9637AF2EEFAD, 3, 12, 4);
  }
  public ref float MassInv {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC96376218E3D2));
  }
  public ref float GameMass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC96373EB130F1));
  }
  public ref float MassScaleInv {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC9637F3E9CDBA));
  }
  public ref float InertiaScaleInv {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC963772594E66));
  }
  public ref float LinearDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC96374E6B7F64));
  }
  public ref float AngularDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC96370E32E897));
  }
  public ref float LinearDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC9637B3D686BC));
  }
  public ref float AngularDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC9637DCE9A7D1));
  }
  public ref float LinearBuoyancyDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC963766B37CD2));
  }
  public ref float AngularBuoyancyDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC963731B6B8C7));
  }
  public ref Vector LastAwakeForceAccum {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC9637BE6733F6));
  }
  public ref Vector LastAwakeTorqueAccum {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC9637BC86B231));
  }
  public ref float BuoyancyFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC96374A0360BE));
  }
  public ref float GravityScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC9637328A3947));
  }
  public ref float TimeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB8BC9637B49D735C));
  }
  public ref int BodyType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB8BC9637415309A9));
  }
  public ref uint GameIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB8BC963764506BB1));
  }
  public ref uint GameFlags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xB8BC96370C8F0212));
  }
  public ref byte MinVelocityIterations {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB8BC9637F89809A8));
  }
  public ref byte MinPositionIterations {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB8BC963721060B7C));
  }
  public ref byte MassPriority {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB8BC96377BA92709));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC96376154EB7E));
  }
  public ref bool Sleeping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC9637024A38E0));
  }
  public ref bool IsContinuousEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC9637361FE49F));
  }
  public ref bool DragEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC96370FDF5278));
  }
  public ref bool BuoyancyDragEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC96378B215DDA));
  }
  public ref Vector Gravity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB8BC9637A5AE4779));
  }
  public ref bool SpeculativeEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC963753C4B251));
  }
  public ref bool HasShadowController {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB8BC9637FA7D743F));
  }
  public ref DynamicContinuousContactBehavior_t DynamicContinuousContactBehavior {
    get => ref _Handle.AsRef<DynamicContinuousContactBehavior_t>(Schema.GetOffset(0xB8BC96374846D0CD));
  }


}