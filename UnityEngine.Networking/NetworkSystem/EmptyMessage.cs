﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.NetworkSystem.EmptyMessage
// Assembly: UnityEngine.Networking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8B34E19C-EF53-416E-AE36-35C45BAFD2DE
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.Networking.dll

namespace UnityEngine.Networking.NetworkSystem
{
  /// <summary>
  ///   <para>A utility class to send a network message with no contents.</para>
  /// </summary>
  public class EmptyMessage : MessageBase
  {
    public override void Deserialize(NetworkReader reader)
    {
    }

    public override void Serialize(NetworkWriter writer)
    {
    }
  }
}
