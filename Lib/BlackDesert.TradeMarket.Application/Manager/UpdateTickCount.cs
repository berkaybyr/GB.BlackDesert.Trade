using BlackDesert.TradeMarket.Application.Xml;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class UpdateTickCount
    {
        private static object _locker = new object();
        private static bool _flag = false;

        public static void Excute(object state)
        {
            lock (_locker)
            {
                if (_flag)
                    return;
                _flag = true;
            }
            try
            {
                updateTickCount();
                ServerLogManager.ServerLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]UpdateTickCount", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]UpdateTickCount Exception={1}", state, ex.ToString()), "ERROR");
            }
            lock (_locker)
                _flag = false;
        }

        private static void updateTickCount()
        {
            if (!ServerControlManager.This().IsLoadComplete())
                LogUtil.WriteLog(string.Format("updateTickCount Fail is Not Open"), "WARN");
            else if (WorldMarketOptionManager.This().isSleepTime())
                LogUtil.WriteLog(string.Format("[Update INFO]updateTickCount() isSleepTime {0}", DateTime.Now.Hour), "INFO");
            else
                TickCountManager.This().updateTickCountXXX();
        }
    }
}
