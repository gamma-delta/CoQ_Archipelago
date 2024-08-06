namespace PKARC {
  using System;
  using XRL;
  using XRL.World;

  using Archipelago.MultiClient.Net;

  [Serializable]
  public class ArchipelagoSystem : IGameSystem {
    // Nullable
    public ArchipelagoSession SESSION = null;
  }

  [HasGameBasedStaticCache]
  public class Tester {
    [GameBasedCacheInit]
    public static void Test() {
      XRL.Messages.MessageQueue.AddPlayerMessage("Hello, {{extradimensional|"
        + nameof(ArchipelagoSession) + "}}!");
    }
  }
}
