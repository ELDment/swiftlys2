using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum EntityEffects_t : ushort {

 DEPRICATED_EF_NOINTERP = 8;
 EF_NOSHADOW = 16;
 EF_NODRAW = 32;
 EF_NORECEIVESHADOW = 64;
 EF_PARENT_ANIMATES = 512;
 EF_NODRAW_BUT_TRANSMIT = 1024;
 EF_MAX_BITS = 10;
}