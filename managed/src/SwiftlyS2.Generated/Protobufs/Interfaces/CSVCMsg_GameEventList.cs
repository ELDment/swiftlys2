
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSVCMsg_GameEventList : ITypedProtobuf<CSVCMsg_GameEventList>
{
  static CSVCMsg_GameEventList ITypedProtobuf<CSVCMsg_GameEventList>.Wrap(nint handle) => new CSVCMsg_GameEventListImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CSVCMsg_GameEventList_descriptor_t> Descriptors { get; }

}
