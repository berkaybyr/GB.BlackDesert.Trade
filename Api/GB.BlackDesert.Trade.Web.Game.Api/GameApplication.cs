// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.MvcApplication
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;


namespace BlackDesert.TradeMarket.Game.Api
{
    public static class GameApplication
    {
        public static Task InitializeOnceAsync() => Task.Run((Action)(() => InitializeOnce()));
        private static void InitializeOnce()
        {
            var openResult = ServerControlManager.This().Open(ServerType.eGame) == 0;
            var dataInitResult = ServerControlManager.This().dataInit(ServerType.eGame) == 0;
            var timerResult = ServerControlManager.This().TimerOpen(ServerType.eGame) == 0;
            if (!openResult || !dataInitResult || !timerResult)
                return;
            AuthenticateManager._servcerType = ServerType.eGame;
            ServerControlManager.This().LoadComplete(ServerType.eGame);
        }


    }
}
