using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Shared.Plugins;

public interface IPlugin {

  public void ConfigureSharedInterface(IInterfaceManager interfaceManager);

  public void UseSharedInterface(IInterfaceManager interfaceManager);

  public void Load(bool hotReload);

  public void Unload();

}