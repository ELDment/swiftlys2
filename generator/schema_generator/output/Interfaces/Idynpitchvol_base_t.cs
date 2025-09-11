using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Idynpitchvol_base_t : ISchemaClass {

  
  public ref int Preset { get; }
  
  public ref int Pitchrun { get; }
  
  public ref int Pitchstart { get; }
  
  public ref int Spinup { get; }
  
  public ref int Spindown { get; }
  
  public ref int Volrun { get; }
  
  public ref int Volstart { get; }
  
  public ref int Fadein { get; }
  
  public ref int Fadeout { get; }
  
  public ref int Lfotype { get; }
  
  public ref int Lforate { get; }
  
  public ref int Lfomodpitch { get; }
  
  public ref int Lfomodvol { get; }
  
  public ref int Cspinup { get; }
  
  public ref int Cspincount { get; }
  
  public ref int Pitch { get; }
  
  public ref int Spinupsav { get; }
  
  public ref int Spindownsav { get; }
  
  public ref int Pitchfrac { get; }
  
  public ref int Vol { get; }
  
  public ref int Fadeinsav { get; }
  
  public ref int Fadeoutsav { get; }
  
  public ref int Volfrac { get; }
  
  public ref int Lfofrac { get; }
  
  public ref int Lfomult { get; }
}