using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public enum CSPlayerBlockingUseAction_t : uint {

 k_CSPlayerBlockingUseAction_None = 0;
 k_CSPlayerBlockingUseAction_DefusingDefault = 1;
 k_CSPlayerBlockingUseAction_DefusingWithKit = 2;
 k_CSPlayerBlockingUseAction_HostageGrabbing = 3;
 k_CSPlayerBlockingUseAction_HostageDropping = 4;
 k_CSPlayerBlockingUseAction_MapLongUseEntity_Pickup = 5;
 k_CSPlayerBlockingUseAction_MapLongUseEntity_Place = 6;
 k_CSPlayerBlockingUseAction_MaxCount = 7;
}