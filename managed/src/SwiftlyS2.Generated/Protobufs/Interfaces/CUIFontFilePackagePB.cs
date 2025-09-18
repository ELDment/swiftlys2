
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUIFontFilePackagePB : ITypedProtobuf<CUIFontFilePackagePB>
{
  static CUIFontFilePackagePB ITypedProtobuf<CUIFontFilePackagePB>.Wrap(nint handle) => new CUIFontFilePackagePBImpl(handle);


  public uint PackageVersion { get; set; }


  public IProtobufRepeatedFieldSubMessageType<CUIFontFilePackagePB_CUIEncryptedFontFilePB> EncryptedFontFiles { get; }

}
