namespace SwiftlyS2.Shared.Convars;

public interface IConVarService {
  
  /// <summary>
  /// Find a existing convar by name.
  /// </summary>
  /// <typeparam name="T">The type of the convar.</typeparam>
  /// <param name="name">The name of the convar.</param>
  /// <returns>The convar if found, null otherwise.</returns>
  IConVar<T>? Find<T>(string name);

  /// <summary>
  /// Create a new convar.
  /// </summary>
  /// <typeparam name="T">The type of the convar.</typeparam>
  /// <param name="name">The name of the convar.</param>
  /// <param name="helpMessage">The help message of the convar.</param>
  /// <param name="defaultValue">The default value of the convar.</param>
  /// <param name="flags">The flags of the convar.</param>
  /// <returns>The created convar.</returns>
  /// <returns>Reference to the created convar.</returns>
  IConVar<T> Create<T>(string name, string helpMessage, T defaultValue, ConvarFlags flags = ConvarFlags.NONE);
}