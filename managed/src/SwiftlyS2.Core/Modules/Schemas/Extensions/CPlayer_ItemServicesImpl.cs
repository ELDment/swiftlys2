using SwiftlyS2.Core.EntitySystem;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_ItemServicesImpl
{

  public T GiveItem<T>() where T : ISchemaClass<T> {
    var name = EntitySystemService.TypeToDesignerName[typeof(T)];
    return T.From(GameFunctions.CCSPlayer_ItemServices_GiveNamedItem(Address, name));
  }

  public void RemoveItems() {
    GameFunctions.CCSPlayer_ItemServices_RemoveWeapons(Address);
  }

  public void DropActiveItem() {
    GameFunctions.CCSPlayer_ItemServices_DropActiveItem(Address, Vector.Zero);
  }

}