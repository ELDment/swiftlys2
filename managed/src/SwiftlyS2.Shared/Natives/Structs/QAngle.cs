using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

/// <summary>
/// QAngle is a type that contains 3 float, representing an angle.
/// Degree Euler. Pitch, Yaw, Roll
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 12)]
public struct QAngle
{
  public float Pitch;
  public float Yaw;
  public float Roll;

  public QAngle(float pitch, float yaw, float roll)
  {
    Pitch = pitch;
    Yaw = yaw;
    Roll = roll;
  }

  public QAngle(QAngle other)
  {
    Pitch = other.Pitch;
    Yaw = other.Yaw;
    Roll = other.Roll;
  }

  public RadianEuler ToRadianEuler() => new(Pitch * MathF.PI / 180.0f, Yaw * MathF.PI / 180.0f, Roll * MathF.PI / 180.0f);

  public override bool Equals(object? obj) => obj is QAngle angle && this == angle;
  public override int GetHashCode() => HashCode.Combine(Pitch, Yaw, Roll);
  public override string ToString() => $"QAngle({Pitch}, {Yaw}, {Roll})";

  public static QAngle Zero => new(0, 0, 0);


  [MethodImpl(MethodImplOptions.AggressiveInlining)]

  public static QAngle operator +(QAngle a, QAngle b) => new(a.Pitch + b.Pitch, a.Yaw + b.Yaw, a.Roll + b.Roll);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static QAngle operator -(QAngle a, QAngle b) => new(a.Pitch - b.Pitch, a.Yaw - b.Yaw, a.Roll - b.Roll);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static QAngle operator *(QAngle a, QAngle b) => new(a.Pitch * b.Pitch, a.Yaw * b.Yaw, a.Roll * b.Roll);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static QAngle operator /(QAngle a, QAngle b) => new(a.Pitch / b.Pitch, a.Yaw / b.Yaw, a.Roll / b.Roll);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]  
  public static QAngle operator *(QAngle a, float b) => new(a.Pitch * b, a.Yaw * b, a.Roll * b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static QAngle operator /(QAngle a, float b) {
    if (b == 0) {
      throw new DivideByZeroException();
    }
    var oofl = 1.0f / b;
    return new(a.Pitch * oofl, a.Yaw * oofl, a.Roll * oofl);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static QAngle operator -(QAngle a) => new(-a.Pitch, -a.Yaw, -a.Roll);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool operator ==(QAngle a, QAngle b) => a.Pitch == b.Pitch && a.Yaw == b.Yaw && a.Roll == b.Roll;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool operator !=(QAngle a, QAngle b) => a.Pitch != b.Pitch || a.Yaw != b.Yaw || a.Roll != b.Roll;

}
