using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;
  
internal class ProtobufAccessor : NativeHandle, IProtobufAccessor {


  public ProtobufAccessor() : base(0) {
  }

  public void InternalSet(nint handle) {
    _Handle = handle;
  }

  public bool GetBool(string fieldName)
  {
    return NativeNetMessages.GetBool(GetHandle(), fieldName);
  }

  public void SetBool(string fieldName, bool value)
  {
    NativeNetMessages.SetBool(GetHandle(), fieldName, value);
  }

  public void SetInt32(string fieldName, int value)
  {
    NativeNetMessages.SetInt32(GetHandle(), fieldName, value);
  }

  public int GetInt32(string fieldName) {
    return NativeNetMessages.GetInt32(GetHandle(), fieldName);
  }

  public void SetUInt32(string fieldName, uint value) {
    NativeNetMessages.SetUInt32(GetHandle(), fieldName, value);
  }

  public uint GetUInt32(string fieldName) {
    return NativeNetMessages.GetUInt32(GetHandle(), fieldName);
  }


  public void SetInt64(string fieldName, long value)
  {
    NativeNetMessages.SetInt64(GetHandle(), fieldName, value);
  }

  public long GetInt64(string fieldName)
  {
    return NativeNetMessages.GetInt64(GetHandle(), fieldName);
  }

  public void SetUInt64(string fieldName, ulong value) {
    NativeNetMessages.SetUInt64(GetHandle(), fieldName, value);
  }

  public ulong GetUInt64(string fieldName) {
    return NativeNetMessages.GetUInt64(GetHandle(), fieldName);
  }


  public float GetFloat(string fieldName) {
    return NativeNetMessages.GetFloat(GetHandle(), fieldName);
  }

  public void SetFloat(string fieldName, float value) {
    NativeNetMessages.SetFloat(GetHandle(), fieldName, value);
  }

  public double GetDouble(string fieldName) {
    return NativeNetMessages.GetDouble(GetHandle(), fieldName);
  }

  public void SetDouble(string fieldName, double value) {
    NativeNetMessages.SetDouble(GetHandle(), fieldName, value);
  }

  public string GetString(string fieldName) {
    return NativeNetMessages.GetString(GetHandle(), fieldName);
  }

  public void SetString(string fieldName, string value) {   
    NativeNetMessages.SetString(GetHandle(), fieldName, value);
  }

  public void SetBytes(string fieldName, byte[] value) {
    NativeNetMessages.SetBytes(GetHandle(), fieldName, value);
  }

  public byte[] GetBytes(string fieldName) {
    return NativeNetMessages.GetBytes(GetHandle(), fieldName);
  }

  public void SetVector2D(string fieldName, Vector2D value) {
    NativeNetMessages.SetVector2D(GetHandle(), fieldName, value);
  }

  public Vector2D GetVector2D(string fieldName) {
    return NativeNetMessages.GetVector2D(GetHandle(), fieldName);
  }

  public void SetVector(string fieldName, Vector value) {
    NativeNetMessages.SetVector(GetHandle(), fieldName, value);
  }

  public Vector GetVector(string fieldName) {
    return NativeNetMessages.GetVector(GetHandle(), fieldName);
  }

  public void SetColor(string fieldName, Color value) {
    NativeNetMessages.SetColor(GetHandle(), fieldName, value);
  }

  public Color GetColor(string fieldName) {
    return NativeNetMessages.GetColor(GetHandle(), fieldName);
  }

  public void SetQAngle(string fieldName, QAngle value) {
    NativeNetMessages.SetQAngle(GetHandle(), fieldName, value);
  }

  public QAngle GetQAngle(string fieldName) {
    return NativeNetMessages.GetQAngle(GetHandle(), fieldName);
  }


  public unsafe nint GetNestedMessage(string fieldName)
  {
    return NativeNetMessages.GetNestedMessage(GetHandle(), fieldName);
  }


  // Repeated field accessors
  public bool GetRepeatedBool(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedBool(GetHandle(), fieldName, index);
  }

  public void SetRepeatedBool(string fieldName, int index, bool value)
  {
    NativeNetMessages.SetRepeatedBool(GetHandle(), fieldName, index, value);
  }

  public void AddBool(string fieldName, bool value)
  {
    NativeNetMessages.AddBool(GetHandle(), fieldName, value);
  }

  public int GetRepeatedInt32(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedInt32(GetHandle(), fieldName, index);
  }

  public void SetRepeatedInt32(string fieldName, int index, int value)
  {
    NativeNetMessages.SetRepeatedInt32(GetHandle(), fieldName, index, value);
  }

  public void AddInt32(string fieldName, int value)
  {
    NativeNetMessages.AddInt32(GetHandle(), fieldName, value);
  }

  public uint GetRepeatedUInt32(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedUInt32(GetHandle(), fieldName, index);
  }

  public void SetRepeatedUInt32(string fieldName, int index, uint value)
  {
    NativeNetMessages.SetRepeatedUInt32(GetHandle(), fieldName, index, value);
  }

  public void AddUInt32(string fieldName, uint value)
  {
    NativeNetMessages.AddUInt32(GetHandle(), fieldName, value);
  }

  public long GetRepeatedInt64(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedInt64(GetHandle(), fieldName, index);
  }

  public void SetRepeatedInt64(string fieldName, int index, long value)
  {
    NativeNetMessages.SetRepeatedInt64(GetHandle(), fieldName, index, value);
  }

  public void AddInt64(string fieldName, long value)
  {
    NativeNetMessages.AddInt64(GetHandle(), fieldName, value);
  }

  public ulong GetRepeatedUInt64(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedUInt64(GetHandle(), fieldName, index);
  }

  public void SetRepeatedUInt64(string fieldName, int index, ulong value)
  {
    NativeNetMessages.SetRepeatedUInt64(GetHandle(), fieldName, index, value);
  }

  public void AddUInt64(string fieldName, ulong value)
  {
    NativeNetMessages.AddUInt64(GetHandle(), fieldName, value);
  }

  public float GetRepeatedFloat(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedFloat(GetHandle(), fieldName, index);
  }

  public void SetRepeatedFloat(string fieldName, int index, float value)
  {
    NativeNetMessages.SetRepeatedFloat(GetHandle(), fieldName, index, value);
  }

  public void AddFloat(string fieldName, float value)
  {
    NativeNetMessages.AddFloat(GetHandle(), fieldName, value);
  }

  public double GetRepeatedDouble(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedDouble(GetHandle(), fieldName, index);
  }

  public void SetRepeatedDouble(string fieldName, int index, double value)
  {
    NativeNetMessages.SetRepeatedDouble(GetHandle(), fieldName, index, value);
  }

  public void AddDouble(string fieldName, double value)
  {
    NativeNetMessages.AddDouble(GetHandle(), fieldName, value);
  }

  public string GetRepeatedString(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedString(GetHandle(), fieldName, index);
  }

  public void SetRepeatedString(string fieldName, int index, string value)
  {
    NativeNetMessages.SetRepeatedString(GetHandle(), fieldName, index, value);
  }

  public void AddString(string fieldName, string value)
  {
    NativeNetMessages.AddString(GetHandle(), fieldName, value);
  }

  public byte[] GetRepeatedBytes(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedBytes(GetHandle(), fieldName, index);
  }

  public void SetRepeatedBytes(string fieldName, int index, byte[] value)
  {
    NativeNetMessages.SetRepeatedBytes(GetHandle(), fieldName, index, value);
  }

  public void AddBytes(string fieldName, byte[] value)
  {
    NativeNetMessages.AddBytes(GetHandle(), fieldName, value);
  }

  public Vector2D GetRepeatedVector2D(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedVector2D(GetHandle(), fieldName, index);
  }

  public void SetRepeatedVector2D(string fieldName, int index, Vector2D value)
  {
    NativeNetMessages.SetRepeatedVector2D(GetHandle(), fieldName, index, value);
  }

  public void AddVector2D(string fieldName, Vector2D value)
  {
    NativeNetMessages.AddVector2D(GetHandle(), fieldName, value);
  }

  public Vector GetRepeatedVector(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedVector(GetHandle(), fieldName, index);
  }

  public void SetRepeatedVector(string fieldName, int index, Vector value)
  {
    NativeNetMessages.SetRepeatedVector(GetHandle(), fieldName, index, value);
  }

  public void AddVector(string fieldName, Vector value)
  {
    NativeNetMessages.AddVector(GetHandle(), fieldName, value);
  }

  public Color GetRepeatedColor(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedColor(GetHandle(), fieldName, index);
  }

  public void SetRepeatedColor(string fieldName, int index, Color value)
  {
    NativeNetMessages.SetRepeatedColor(GetHandle(), fieldName, index, value);
  }

  public void AddColor(string fieldName, Color value)
  {
    NativeNetMessages.AddColor(GetHandle(), fieldName, value);
  }

  public QAngle GetRepeatedQAngle(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedQAngle(GetHandle(), fieldName, index);
  }

  public void SetRepeatedQAngle(string fieldName, int index, QAngle value)
  {
    NativeNetMessages.SetRepeatedQAngle(GetHandle(), fieldName, index, value);
  }

  public void AddQAngle(string fieldName, QAngle value)
  {
    NativeNetMessages.AddQAngle(GetHandle(), fieldName, value);
  }

  public unsafe nint GetRepeatedNestedMessage(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedNestedMessage(GetHandle(), fieldName, index);
  }

  public unsafe nint AddNestedMessage(string fieldName)
  {
    return NativeNetMessages.AddNestedMessage(GetHandle(), fieldName);
  }

  public int GetRepeatedFieldSize(string fieldName)
  {
    return NativeNetMessages.GetRepeatedFieldSize(GetHandle(), fieldName);
  }

  public void ClearRepeatedField(string fieldName)
  {
    NativeNetMessages.ClearRepeatedField(GetHandle(), fieldName);
  }

  public T Get<T>(string fieldName) {
    if (typeof(T) == typeof(bool)) {
      return (T)(object)GetBool(fieldName);
    }
    else if (typeof(T) == typeof(int)) {
      return (T)(object)GetInt32(fieldName);
    }
    else if (typeof(T) == typeof(uint)) {
      return (T)(object)GetUInt32(fieldName);
    }
    else if (typeof(T) == typeof(long)) {
      return (T)(object)GetInt64(fieldName);
    }
    else if (typeof(T) == typeof(ulong)) {
      return (T)(object)GetUInt64(fieldName);
    }
    else if (typeof(T) == typeof(float)) {
      return (T)(object)GetFloat(fieldName);
    }
    else if (typeof(T) == typeof(double)) {
      return (T)(object)GetDouble(fieldName);
    }
    else if (typeof(T) == typeof(string)) {
      return (T)(object)GetString(fieldName);
    }
    else if (typeof(T) == typeof(byte[])) {
      return (T)(object)GetBytes(fieldName);
    }
    else if (typeof(T) == typeof(Vector2D)) {
      return (T)(object)GetVector2D(fieldName);
    }
    else if (typeof(T) == typeof(Vector)) {
      return (T)(object)GetVector(fieldName);
    }
    else if (typeof(T) == typeof(Color)) {
      return (T)(object)GetColor(fieldName);
    }
    else if (typeof(T) == typeof(QAngle)) {
      return (T)(object)GetQAngle(fieldName);
    }
    throw new InvalidOperationException($"Invalid type: {typeof(T)}");
  }

  public void Set<T>(string fieldName, T value) {
    if (typeof(T) == typeof(bool)) {
      SetBool(fieldName, (bool)(object)value!);
    }
    else if (typeof(T) == typeof(int)) {
      SetInt32(fieldName, (int)(object)value!);
    }
    else if (typeof(T) == typeof(uint)) {
      SetUInt32(fieldName, (uint)(object)value!);
    }
    else if (typeof(T) == typeof(long)) {
      SetInt64(fieldName, (long)(object)value!);
    }
    else if (typeof(T) == typeof(ulong)) {
      SetUInt64(fieldName, (ulong)(object)value!);
    }
    else if (typeof(T) == typeof(float)) {
      SetFloat(fieldName, (float)(object)value!);
    }
    else if (typeof(T) == typeof(double)) {
      SetDouble(fieldName, (double)(object)value!);
    }
    else if (typeof(T) == typeof(string)) {
      SetString(fieldName, (string)(object)value!);
    }
    else if (typeof(T) == typeof(byte[])) {
      SetBytes(fieldName, (byte[])(object)value!);
    }
    else if (typeof(T) == typeof(Vector2D)) {
      SetVector2D(fieldName, (Vector2D)(object)value!);
    }
    else if (typeof(T) == typeof(Vector)) {
      SetVector(fieldName, (Vector)(object)value!);
    }
    else if (typeof(T) == typeof(Color)) {
      SetColor(fieldName, (Color)(object)value!);
    }
    else if (typeof(T) == typeof(QAngle)) {
      SetQAngle(fieldName, (QAngle)(object)value!);
    }
    throw new InvalidOperationException($"Invalid type: {typeof(T)}");
  }

  public void Add<T>(string fieldName, T value) {
    if (typeof(T) == typeof(bool)) {
      AddBool(fieldName, (bool)(object)value!);
    }
    else if (typeof(T) == typeof(int)) {
      AddInt32(fieldName, (int)(object)value!);
    }
    else if (typeof(T) == typeof(uint)) {
      AddUInt32(fieldName, (uint)(object)value!);
    }
    else if (typeof(T) == typeof(long)) {
      AddInt64(fieldName, (long)(object)value!);
    }
    else if (typeof(T) == typeof(ulong)) {
      AddUInt64(fieldName, (ulong)(object)value!);
    }
    else if (typeof(T) == typeof(float)) {
      AddFloat(fieldName, (float)(object)value!);
    }
    else if (typeof(T) == typeof(double)) {
      AddDouble(fieldName, (double)(object)value!);
    }
    else if (typeof(T) == typeof(string)) {
      AddString(fieldName, (string)(object)value!);
    }
    else if (typeof(T) == typeof(byte[])) {
      AddBytes(fieldName, (byte[])(object)value!);
    }
    else if (typeof(T) == typeof(Vector2D)) {
      AddVector2D(fieldName, (Vector2D)(object)value!);
    }
    else if (typeof(T) == typeof(Vector)) {
      AddVector(fieldName, (Vector)(object)value!);
    }
    else if (typeof(T) == typeof(Color)) {
      AddColor(fieldName, (Color)(object)value!);
    }
    else if (typeof(T) == typeof(QAngle)) {
      AddQAngle(fieldName, (QAngle)(object)value!);
    }
    throw new InvalidOperationException($"Invalid type: {typeof(T)}");
  }

  public void SetRepeated<T>(string fieldName, int index, T value) {
    if (typeof(T) == typeof(bool)) {
      SetRepeatedBool(fieldName, index, (bool)(object)value!);
    }
    else if (typeof(T) == typeof(int)) {
      SetRepeatedInt32(fieldName, index, (int)(object)value!);
    }
    else if (typeof(T) == typeof(uint)) {
      SetRepeatedUInt32(fieldName, index, (uint)(object)value!);
    }
    else if (typeof(T) == typeof(long)) {
      SetRepeatedInt64(fieldName, index, (long)(object)value!);
    }
    else if (typeof(T) == typeof(ulong)) {
      SetRepeatedUInt64(fieldName, index, (ulong)(object)value!);
    }
    else if (typeof(T) == typeof(float)) {
      SetRepeatedFloat(fieldName, index, (float)(object)value!);
    }
    else if (typeof(T) == typeof(double)) {
      SetRepeatedDouble(fieldName, index, (double)(object)value!);
    }
    else if (typeof(T) == typeof(string)) {
      SetRepeatedString(fieldName, index, (string)(object)value!);
    }
    else if (typeof(T) == typeof(byte[])) {
      SetRepeatedBytes(fieldName, index, (byte[])(object)value!);
    }
    else if (typeof(T) == typeof(Vector2D)) {
      SetRepeatedVector2D(fieldName, index, (Vector2D)(object)value!);
    }
    else if (typeof(T) == typeof(Vector)) {
      SetRepeatedVector(fieldName, index, (Vector)(object)value!);
    }
    else if (typeof(T) == typeof(Color)) {
      SetRepeatedColor(fieldName, index, (Color)(object)value!);
    }
    else if (typeof(T) == typeof(QAngle)) {
      SetRepeatedQAngle(fieldName, index, (QAngle)(object)value!);
    }
    throw new InvalidOperationException($"Invalid type: {typeof(T)}");
  }

  public T GetRepeated<T>(string fieldName, int index) {
    if (typeof(T) == typeof(bool)) {
      return (T)(object)GetRepeatedBool(fieldName, index);
    }
    else if (typeof(T) == typeof(int)) {
      return (T)(object)GetRepeatedInt32(fieldName, index);
    }
    else if (typeof(T) == typeof(uint)) {
      return (T)(object)GetRepeatedUInt32(fieldName, index);
    }
    else if (typeof(T) == typeof(long)) {
      return (T)(object)GetRepeatedInt64(fieldName, index);
    }
    else if (typeof(T) == typeof(ulong)) {
      return (T)(object)GetRepeatedUInt64(fieldName, index);
    }
    else if (typeof(T) == typeof(float)) {
      return (T)(object)GetRepeatedFloat(fieldName, index);
    }
    else if (typeof(T) == typeof(double)) {
      return (T)(object)GetRepeatedDouble(fieldName, index);
    }
    else if (typeof(T) == typeof(string)) {
      return (T)(object)GetRepeatedString(fieldName, index);
    }
    else if (typeof(T) == typeof(byte[])) {
      return (T)(object)GetRepeatedBytes(fieldName, index);
    }
    else if (typeof(T) == typeof(Vector2D)) {
      return (T)(object)GetRepeatedVector2D(fieldName, index);
    }
    else if (typeof(T) == typeof(Vector)) {
      return (T)(object)GetRepeatedVector(fieldName, index);
    }
    else if (typeof(T) == typeof(Color)) {
      return (T)(object)GetRepeatedColor(fieldName, index);
    }
    else if (typeof(T) == typeof(QAngle)) {
      return (T)(object)GetRepeatedQAngle(fieldName, index);
    }
    throw new InvalidOperationException($"Invalid type: {typeof(T)}");  
  }
}