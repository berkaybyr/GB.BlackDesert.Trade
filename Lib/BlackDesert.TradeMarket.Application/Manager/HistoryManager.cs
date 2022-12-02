
namespace BlackDesert.TradeMarket.Application.Manager
{
    internal class HistoryManager
    {
        private static volatile HistoryManager _singleton;
        private static object _locker = new object();
        private const string _managerName = "HistoryManager";

        public static HistoryManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new HistoryManager();
                }
            }
            return _singleton;
        }

        public int Open(ServerType serverType)
        {
            int num1 = 0;
            TradeMarketServerInfo serverInfo = WorldMarketServerInfoManager.This().getServerInfo();
            if (serverInfo != null)
            {
                if (serverType != serverInfo._serverType && serverInfo._serverType != ServerType.eAll)
                {
                    LogUtil.WriteLog(string.Format("서버 타입과 맞지 않는 타이머를 설정하려고 합니다. 서버타입 = {0}, 설정한 서버 타입 = {1}", serverType, serverInfo._serverType), "WARN");
                    return -1;
                }
                Stopwatch stopwatch = new Stopwatch();
                ServerLogManager.ServerLogWrite(ServerLogType.eStart, nameof(HistoryManager));
                stopwatch.Start();
                if (serverInfo._isInitHistory)
                {
                    switch (serverType)
                    {
                        case ServerType.eGame:
                            int num2 = TradeModule.historyInit();
                            if (num2 != 0)
                            {
                                LogUtil.WriteLog(string.Format("[{0}]fail HistoryInit - 히스토리를 초기화 할 때 에러가 발생했습니다. resultCode({1})", serverType, num2), "WARN");
                                return -2;
                            }
                            num1 = TradeModule.noticeInfoInitByGame();
                            if (num1 != 0)
                            {
                                LogUtil.WriteLog(string.Format("[{0}]fail noticeInfoInitByGame - notice정보를 초기화 할 때 에러가 발생했습니다. resultCode({1})", serverType, num1), "WARN");
                                return -4;
                            }
                            break;
                        case ServerType.eProcess:
                            num1 = TradeModule.noticeInfoInitByTrade();
                            if (num1 != 0)
                            {
                                LogUtil.WriteLog(string.Format("[{0}]fail noticeInfoInitByTrade - notice정보를 초기화 할 때 에러가 발생했습니다. resultCode({1})", serverType, num1), "WARN");
                                return -5;
                            }
                            break;
                        default:
                            LogUtil.WriteLog(string.Format("[{0}]Not Init - 해당 서버 타입은 데이터 초기화가 불가 합니다.", serverType), "WARN");
                            return -3;
                    }
                }
                stopwatch.Stop();
                ServerLogManager.ServerLogWrite(ServerLogType.eComplete, nameof(HistoryManager), stopwatch.ElapsedMilliseconds.ToString());
            }
            return num1;
        }
    }
}
