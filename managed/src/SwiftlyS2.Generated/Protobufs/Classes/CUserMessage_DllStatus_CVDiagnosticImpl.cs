
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CUserMessage_DllStatus_CVDiagnosticImpl : TypedProtobuf<CUserMessage_DllStatus_CVDiagnostic>, CUserMessage_DllStatus_CVDiagnostic
{
  public CUserMessage_DllStatus_CVDiagnosticImpl(nint handle): base(handle)
  {
  }


  public uint Id
  { get => Accessor.GetUInt32("id"); set => Accessor.SetUInt32("id", value); }


  public uint Extended
  { get => Accessor.GetUInt32("extended"); set => Accessor.SetUInt32("extended", value); }


  public ulong Value
  { get => Accessor.GetUInt64("value"); set => Accessor.SetUInt64("value", value); }


  public string StringValue
  { get => Accessor.GetString("string_value"); set => Accessor.SetString("string_value", value); }

}
