using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEconItemView : IEconItemInterface, IEconItemView {

  public CEconItemView(nint handle) : base(handle) {
  }

  public CEconItemView(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort ItemDefinitionIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xE1A93F25A2CCB41A));
  }
  public ref int EntityQuality {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE1A93F256A67D4C4));
  }
  public ref uint EntityLevel {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE1A93F2555EF3B5F));
  }
  public ref ulong ItemID {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0xE1A93F2534B55816));
  }
  public ref uint ItemIDHigh {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE1A93F25373EE446));
  }
  public ref uint ItemIDLow {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE1A93F250DF29C2C));
  }
  public ref uint AccountID {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE1A93F25C65DE986));
  }
  public ref uint InventoryPosition {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xE1A93F2592F42873));
  }
  public ref bool Initialized {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE1A93F250710ABDD));
  }
  public IAttributeList AttributeList {
    get => new CAttributeList(_Handle + Schema.GetOffset(0xE1A93F25EF065D97));
  }
  public IAttributeList NetworkedDynamicAttributes {
    get => new CAttributeList(_Handle + Schema.GetOffset(0xE1A93F25B576449C));
  }
  public ISchemaFixedString CustomName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xE1A93F25AFD12EE8));
  }
  public ISchemaFixedString CustomNameOverride {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xE1A93F25A74A6ED8));
  }

  public void ItemDefinitionIndexUpdated() {
    Schema.Update(_Handle, 0xE1A93F25A2CCB41A);
  }
  public void EntityQualityUpdated() {
    Schema.Update(_Handle, 0xE1A93F256A67D4C4);
  }
  public void EntityLevelUpdated() {
    Schema.Update(_Handle, 0xE1A93F2555EF3B5F);
  }
  public void ItemIDHighUpdated() {
    Schema.Update(_Handle, 0xE1A93F25373EE446);
  }
  public void ItemIDLowUpdated() {
    Schema.Update(_Handle, 0xE1A93F250DF29C2C);
  }
  public void AccountIDUpdated() {
    Schema.Update(_Handle, 0xE1A93F25C65DE986);
  }
  public void InventoryPositionUpdated() {
    Schema.Update(_Handle, 0xE1A93F2592F42873);
  }
  public void InitializedUpdated() {
    Schema.Update(_Handle, 0xE1A93F250710ABDD);
  }
  public void AttributeListUpdated() {
    Schema.Update(_Handle, 0xE1A93F25EF065D97);
  }
  public void NetworkedDynamicAttributesUpdated() {
    Schema.Update(_Handle, 0xE1A93F25B576449C);
  }
  public void CustomNameUpdated() {
    Schema.Update(_Handle, 0xE1A93F25AFD12EE8);
  }
}