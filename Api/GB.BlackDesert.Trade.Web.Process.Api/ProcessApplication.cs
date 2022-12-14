
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Manager;

namespace BlackDesert.TradeMarket.Process.Api
{
    public static class ProcessApplication
    {
        public static Task InitializeOnceAsync() => Task.Run((Action)(() => InitializeOnce()));

        private static void InitializeOnce()
        {
            var openResult = ServerControlManager.This().Open(ServerType.eProcess) == 0;
            var dataUpdateResult = ServerControlManager.This().DataUpdateByRepository(ServerType.eProcess) == 0;
            var dataInitResult = ServerControlManager.This().dataInit(ServerType.eProcess) == 0;
            var timerOpenResult = ServerControlManager.This().TimerOpen(ServerType.eProcess) == 0;
            if (!openResult || !dataUpdateResult || !dataInitResult || !timerOpenResult)
                return;
            ServerControlManager.This().LoadComplete(ServerType.eProcess);
        }

    }
}
