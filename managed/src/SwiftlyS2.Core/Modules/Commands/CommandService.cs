using System.Reflection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Commands;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared.Profiler;

namespace SwiftlyS2.Core.Commands;

internal class CommandService : ICommandService, IDisposable {

  private List<CommandCallbackBase> _callbacks = new();
  private ILogger<CommandService> _Logger { get; init; }
  private ILoggerFactory _LoggerFactory { get; init; }
  private IContextedProfilerService _Profiler { get; init; }

  private object _lock = new();

  public CommandService(ILogger<CommandService> logger, ILoggerFactory loggerFactory, IContextedProfilerService profiler) {
    _Logger = logger;
    _LoggerFactory = loggerFactory;
    _Profiler = profiler;
  }

  public Guid RegisterCommand(string commandName, ICommandService.CommandListener handler, bool registerRaw = false) {
    var callback = new CommandCallback(commandName, registerRaw, handler, _LoggerFactory, _Profiler);
    lock (_lock) {
      _callbacks.Add(callback);
    }

    return callback.Guid;
  }

  public void RegisterCommandAlias(string commandName, string alias, bool registerRaw = false) {
    NativeCommands.RegisterAlias(commandName, alias, registerRaw);
  }

  public void UnregisterCommand(Guid guid) {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (callback.Guid == guid) {
          callback.Dispose();
          return true;
        }
        return false;
      });
    }
  }

  public void UnregisterCommand(string commandName) {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (callback is CommandCallback commandCallback && commandCallback.CommandName == commandName) {
          commandCallback.Dispose();
          return true;
        }
        return false;
      });
    }
  }

  public void HookClientCommand(ICommandService.ClientCommandHandler handler) {
    var callback = new ClientCommandListenerCallback(handler, _LoggerFactory, _Profiler);
    lock (_lock) {
      _callbacks.Add(callback);
    }
  }

  public void UnhookClientCommand(Guid guid) {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (callback is ClientCommandListenerCallback clientCommandCallback && clientCommandCallback.Guid == guid) {
          clientCommandCallback.Dispose();
          return true;
        }
        return false;
      });
    }
  }

  public void HookClientChat(ICommandService.ClientChatHandler handler) {
    var callback = new ClientChatListenerCallback(handler, _LoggerFactory, _Profiler);
    lock (_lock) {
      _callbacks.Add(callback);
    }
  }

  public void UnhookClientChat(Guid guid) {
    lock (_lock) {
      _callbacks.RemoveAll(callback => {
        if (callback is ClientChatListenerCallback clientChatListenerCallback && clientChatListenerCallback.Guid == guid) {
          clientChatListenerCallback.Dispose();
          return true;
        }
        return false;
      });
    }
  }

  public void Dispose() {
    lock (_lock) {
      foreach (var callback in _callbacks) {
        callback.Dispose();
      }
      _callbacks.Clear();
    }
  }
}