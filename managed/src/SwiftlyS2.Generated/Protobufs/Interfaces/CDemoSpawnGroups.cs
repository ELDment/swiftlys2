
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoSpawnGroups : ITypedProtobuf<CDemoSpawnGroups>
{
  static CDemoSpawnGroups ITypedProtobuf<CDemoSpawnGroups>.Wrap(nint handle) => new CDemoSpawnGroupsImpl(handle);


  public IProtobufRepeatedFieldValueType<byte[]> Msgs { get; }

}
