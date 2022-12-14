// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.MvcApplication
// Assembly: GB.BlackDesert.Trade.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DEAC0B8-1FEA-450C-A995-66A8A3C53BCF
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;


namespace BlackDesert.TradeMarket.Trade.Api
{
    public static class TradeApplication
    {
        public static Task InitializeOnceAsync() => Task.Run((Action)(() => InitializeOnce()));

        private static void InitializeOnce()
        {
            var openResult = ServerControlManager.This().Open(ServerType.eView) == 0;
            if (!openResult)
                return;
            AuthenticateManager._servcerType = ServerType.eView;
            ServerControlManager.This().LoadComplete(ServerType.eView);
        }

    }
}
