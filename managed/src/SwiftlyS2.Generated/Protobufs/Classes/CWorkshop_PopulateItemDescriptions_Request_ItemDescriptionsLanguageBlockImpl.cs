
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CWorkshop_PopulateItemDescriptions_Request_ItemDescriptionsLanguageBlockImpl : TypedProtobuf<CWorkshop_PopulateItemDescriptions_Request_ItemDescriptionsLanguageBlock>, CWorkshop_PopulateItemDescriptions_Request_ItemDescriptionsLanguageBlock
{
  public CWorkshop_PopulateItemDescriptions_Request_ItemDescriptionsLanguageBlockImpl(nint handle): base(handle)
  {
  }


  public string Language
  { get => Accessor.GetString("language"); set => Accessor.SetString("language", value); }


  public IProtobufRepeatedFieldSubMessageType<CWorkshop_PopulateItemDescriptions_Request_SingleItemDescription> Descriptions
  { get => new ProtobufRepeatedFieldSubMessageType<CWorkshop_PopulateItemDescriptions_Request_SingleItemDescription>(Accessor, "descriptions"); }

}
