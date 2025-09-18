
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_GC2ClientRequestValidation : ITypedProtobuf<CMsgGCCStrike15_v2_GC2ClientRequestValidation>
{
  static CMsgGCCStrike15_v2_GC2ClientRequestValidation ITypedProtobuf<CMsgGCCStrike15_v2_GC2ClientRequestValidation>.Wrap(nint handle) => new CMsgGCCStrike15_v2_GC2ClientRequestValidationImpl(handle);


  public bool FullReport { get; set; }


  public string Module { get; set; }

}
