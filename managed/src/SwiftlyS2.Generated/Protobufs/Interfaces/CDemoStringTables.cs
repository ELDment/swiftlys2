
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoStringTables : ITypedProtobuf<CDemoStringTables>
{
  static CDemoStringTables ITypedProtobuf<CDemoStringTables>.Wrap(nint handle) => new CDemoStringTablesImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CDemoStringTables_table_t> Tables { get; }

}
