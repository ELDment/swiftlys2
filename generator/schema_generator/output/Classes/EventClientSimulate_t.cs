using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventClientSimulate_t : EventSimulate_t, IEventClientSimulate_t {

  public EventClientSimulate_t(nint handle) : base(handle) {
  }




}