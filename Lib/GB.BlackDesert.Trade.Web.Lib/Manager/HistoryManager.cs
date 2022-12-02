// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.HistoryManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System.Diagnostics;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    internal class HistoryManager
    {
        private static volatile HistoryManager _singleton;
        private static object _locker = new object();
        private const string _managerName = "HistoryManager";

        public static HistoryManager This()
        {
            if (HistoryManager._singleton == null)
            {
                lock (HistoryManager._locker)
                {
                    if (HistoryManager._singleton == null)
                        HistoryManager._singleton = new HistoryManager();
                }
            }
            return HistoryManager._singleton;
        }

        public int Open(ServerType serverType)
        {
            int num1 = 0;
            TradeMarketServerInfo serverInfo = WorldMarketServerInfoManager.This().getServerInfo();
            if (serverInfo != null)
            {
                if (serverType != serverInfo._serverType && serverInfo._serverType != ServerType.eAll)
                {
                    LogUtil.WriteLog(string.Format("서버 타입과 맞지 않는 타이머를 설정하려고 합니다. 서버타입 = {0}, 설정한 서버 타입 = {1}", (object)serverType, (object)serverInfo._serverType), "WARN");
                    return -1;
                }
                Stopwatch stopwatch = new Stopwatch();
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(HistoryManager));
                stopwatch.Start();
                if (serverInfo._isInitHistory)
                {
                    switch (serverType)
                    {
                        case ServerType.eGame:
                            int num2 = TradeModule.historyInit();
                            if (num2 != 0)
                            {
                                LogUtil.WriteLog(string.Format("[{0}]fail HistoryInit - 히스토리를 초기화 할 때 에러가 발생했습니다. resultCode({1})", (object)serverType, (object)num2), "WARN");
                                return -2;
                            }
                            num1 = TradeModule.noticeInfoInitByGame();
                            if (num1 != 0)
                            {
                                LogUtil.WriteLog(string.Format("[{0}]fail noticeInfoInitByGame - notice정보를 초기화 할 때 에러가 발생했습니다. resultCode({1})", (object)serverType, (object)num1), "WARN");
                                return -4;
                            }
                            break;
                        case ServerType.eProcess:
                            num1 = TradeModule.noticeInfoInitByTrade();
                            if (num1 != 0)
                            {
                                LogUtil.WriteLog(string.Format("[{0}]fail noticeInfoInitByTrade - notice정보를 초기화 할 때 에러가 발생했습니다. resultCode({1})", (object)serverType, (object)num1), "WARN");
                                return -5;
                            }
                            break;
                        default:
                            LogUtil.WriteLog(string.Format("[{0}]Not Init - 해당 서버 타입은 데이터 초기화가 불가 합니다.", (object)serverType), "WARN");
                            return -3;
                    }
                }
                stopwatch.Stop();
                ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(HistoryManager), stopwatch.ElapsedMilliseconds.ToString());
            }
            return num1;
        }
    }
}
