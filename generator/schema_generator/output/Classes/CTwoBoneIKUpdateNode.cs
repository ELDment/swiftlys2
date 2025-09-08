using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTwoBoneIKUpdateNode : CUnaryUpdateNode, ITwoBoneIKUpdateNode {

  public CTwoBoneIKUpdateNode(nint handle) : base(handle) {
  }

  public ITwoBoneIKSettings_t OpFixedData {
    get => new TwoBoneIKSettings_t(_Handle + Schema.GetOffset(0x419F07E36960AF8C));
  }


}