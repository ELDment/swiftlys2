#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeTest {
  private unsafe static delegate* unmanaged<nint> _Test;
  public unsafe static nint Test() {
    var ret = _Test();
    return ret;
  }
}
