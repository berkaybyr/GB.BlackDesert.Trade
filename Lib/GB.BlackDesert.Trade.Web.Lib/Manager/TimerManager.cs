// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.TimerManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    internal class TimerManager
    {
        private static volatile TimerManager _singleton;
        private static object _locker = new object();
        private List<Timer> timerList = new List<Timer>();
        private const string _managerName = "WorldMarketServerInfoManager";

        public static TimerManager This()
        {
            if (TimerManager._singleton == null)
            {
                lock (TimerManager._locker)
                {
                    if (TimerManager._singleton == null)
                        TimerManager._singleton = new TimerManager();
                }
            }
            return TimerManager._singleton;
        }

        public int Open(ServerType serverType)
        {
            int num = 0;
            lock (TimerManager._locker)
                num = this.timerList.Count;
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
                    LogUtil.WriteLog(string.Format("서버 타입과 맞지 않는 타이머를 설정하려고 합니다. 서버타입 = {0}, 설정한 서버 타입 = {1}", (object)serverType, (object)serverInfo._serverType), "WARN");
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
                            this.timerList.Add(new Timer(new TimerCallback(FetchCommand.Excute), (object)ServerType.eGame, 10000, 10000));
                            ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})FetchCommand", (object)serverType));
                        }
                        this.timerList.Add(new Timer(new TimerCallback(SyncNoticeItemList.Excute), (object)ServerType.eGame, 10000, 10000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})SyncNoticeItemList", (object)serverType));
                        this.timerList.Add(new Timer(new TimerCallback(UpdateCurrentPrice.Excute), (object)ServerType.eGame, 60000, 60000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})UpdateCurrentPrice", (object)serverType));
                        break;
                    }
                    break;
                case ServerType.eProcess:
                    this.timerList.Add(new Timer(new TimerCallback(UpdateTickCount.Excute), (object)ServerType.eProcess, 1800000, 1800000));
                    ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})UpdateTickCount", (object)serverType));
                    if (flag)
                    {
                        this.timerList.Add(new Timer(new TimerCallback(UpdateSystemCount.Excute), (object)ServerType.eProcess, 600000, 600000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})UpdateSystemCount", (object)serverType));
                        this.timerList.Add(new Timer(new TimerCallback(WaitSellItem.Excute), (object)ServerType.eProcess, 10000, 10000));
                        ServerLogManager.serverLogWrite(ServerLogType.eSetTimer, "WorldMarketServerInfoManager" + string.Format("-({0})waitSellItem", (object)serverType));
                        break;
                    }
                    break;
                default:
                    LogUtil.WriteLog(string.Format("[{0}]Not Open Timer - 해당 서버 타입은 타이머를 셋팅할수 없습니다.", (object)serverType), "WARN");
                    return -3;
            }
            lock (TimerManager._locker)
                num = this.timerList.Count;
            stopwatch.Stop();
            LogUtil.WriteLog(string.Format("[{0}]TimerManager 생성 = ({1})", (object)serverType, (object)num), "INFO");
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "WorldMarketServerInfoManager", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }
    }
}
