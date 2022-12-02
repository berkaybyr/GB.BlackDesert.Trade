


namespace BlackDesert.TradeMarket.Application.Manager
{
    internal class TimerManager
    {
        private static volatile TimerManager _singleton;
        private static object _locker = new object();
        private List<Timer> timerList = new List<Timer>();
        private const string _managerName = "WorldMarketServerInfoManager";

        public static TimerManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new TimerManager();
                }
            }
            return _singleton;
        }

        public int Open(ServerType serverType)
        {
            int num = 0;
            lock (_locker)
                num = timerList.Count;
            if (0 < num)
            {
                ServerLogManager.serverLogWrite(ServerLogType.eAlready, "WorldMarketServerInfoManager");
                return -1;
            }
            bool flag = false;
            TradeMarketServerInfo serverInfo = WorldMarketServerInfoManager.This().getServerInfo();
            if (serverInfo != null)
            {
                if (serverType != serverInfo._serverType && serverInfo._serverType != ServerType.eAll)
                {
                    LogUtil.WriteLog(string.Format("서버 타입과 맞지 않는 타이머를 설정하려고 합니다. 서버타입 = {0}, 설정한 서버 타입 = {1}", serverType, serverInfo._serverType), "WARN");
                    return -2;
                }
                flag = serverInfo._setTimer;
            }
            Stopwatch stopwatch = new Stopwatch();
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "WorldMarketServerInfoManager");
            stopwatch.Start();
            switch (serverType)
            {
                case ServerType.eGame:
                    if (flag)
                    {
                        if (ConstantMgr._serviceProject.Equals("BDO"))
                        {
                            timerList.Add(new Timer(new TimerCallback(FetchCommand.Excute), ServerType.eGame, 10000, 10000));
                            ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})FetchCommand", serverType));
                        }
                        timerList.Add(new Timer(new TimerCallback(SyncNoticeItemList.Excute), ServerType.eGame, 10000, 10000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})SyncNoticeItemList", serverType));
                        timerList.Add(new Timer(new TimerCallback(UpdateCurrentPrice.Excute), ServerType.eGame, 60000, 60000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})UpdateCurrentPrice", serverType));
                        break;
                    }
                    break;
                case ServerType.eProcess:
                    timerList.Add(new Timer(new TimerCallback(UpdateTickCount.Excute), ServerType.eProcess, 1800000, 1800000));
                    ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})UpdateTickCount", serverType));
                    if (flag)
                    {
                        timerList.Add(new Timer(new TimerCallback(UpdateSystemCount.Excute), ServerType.eProcess, 600000, 600000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})UpdateSystemCount", serverType));
                        timerList.Add(new Timer(new TimerCallback(WaitSellItem.Excute), ServerType.eProcess, 10000, 10000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})waitSellItem", serverType));
                        break;
                    }
                    break;
                default:
                    LogUtil.WriteLog(string.Format("[{0}]Not Open Timer - 해당 서버 타입은 타이머를 셋팅할수 없습니다.", serverType), "WARN");
                    return -3;
            }
            lock (_locker)
                num = timerList.Count;
            stopwatch.Stop();
            LogUtil.WriteLog(string.Format("[{0}]TimerManager 생성 = ({1})", serverType, num), "INFO");
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "WorldMarketServerInfoManager", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }
    }
}
