using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Models;
using SwiftlyS2.Core.Permissions;
using SwiftlyS2.Shared.Permissions;

namespace SwiftlyS2.Core.Hosting;

public static class PermissionManagerInjection {
  public static IServiceCollection AddPermissionManager(this IServiceCollection self) {
    self.AddSingleton<PermissionManager>();

    self.AddOptions<PermissionConfig>()
      .BindConfiguration("Permissions")
      .ValidateOnStart();

    return self;
  }

  public static void UsePermissionManager(this IServiceProvider self) {
    self.GetRequiredService<PermissionManager>();
  }
}