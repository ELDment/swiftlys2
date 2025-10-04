using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.Events;

internal class OnItemServicesCanAcquireHookEvent : IOnItemServicesCanAcquireHookEvent {
  public required CCSPlayer_ItemServices ItemServices { get; set; }
  public required CEconItemView EconItemView { get; set; }
  public required AcquireMethod AcquireMethod { get; set; }

  public required AcquireResult Result { get; set; }

  public bool Intercepted { get; set; } = false;

  public void SetAcquireResult(AcquireResult result) {
    Result = result;
    Intercepted = true;
  }
}
