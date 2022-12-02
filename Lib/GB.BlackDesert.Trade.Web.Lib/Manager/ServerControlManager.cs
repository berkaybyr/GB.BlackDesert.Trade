// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.ServerControlManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System.Diagnostics;

namespace BlackDesert.TradeMarket.Lib.Manager
{
    public class ServerControlManager
    {
        private static volatile ServerControlManager _singleton;
        private static object _locker = new object();
        private static ServerLoading _dataOpenType = ServerLoading.eReady;
        private static ServerLoading _dbUpdateType = ServerLoading.eReady;
        private static bool _isLoadComplete = false;
        private const string _managerName = "ServerControlManager";

        public static ServerControlManager This()
        {
            if (ServerControlManager._singleton == null)
            {
                lock (ServerControlManager._locker)
                {
                    if (ServerControlManager._singleton == null)
                        ServerControlManager._singleton = new ServerControlManager();
                }
            }
            return ServerControlManager._singleton;
        }

        public int Open(ServerType serverType)
        {
            int errorCode1 = 0;
            lock (ServerControlManager._locker)
            {
                if (ServerLoading.eOpen == ServerControlManager._dataOpenType)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, "ServerControlManager " + this.getConvertServerName(serverType));
                    return 0;
                }
                if (ServerLoading.eLoading == ServerControlManager._dataOpenType)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eLoading, "ServerControlManager " + this.getConvertServerName(serverType));
                    return 0;
                }
                ServerControlManager._dataOpenType = ServerLoading.eLoading;
            }
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "ServerControlManager " + this.getConvertServerName(serverType));
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (ServerType.eProcess == serverType || ServerType.eGame == serverType)
            {
                errorCode1 = WorldMarketServerInfoManager.This().open(serverType);
                if (errorCode1 != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode1, "WorldMarketServerInfoManager open");
                    return errorCode1;
                }
            }
            if (ServerType.eGame == serverType)
            {
                lock (ServerControlManager._locker)
                    ServerControlManager._dataOpenType = ServerLoading.eOpen;
                stopwatch.Stop();
                ServerLogManager.serverLogWrite(ServerLogType.eComplete, "ServerControlManager " + this.getConvertServerName(serverType), stopwatch.ElapsedMilliseconds.ToString());
                return errorCode1;
            }
            //if (ServerType.eView == serverType && isWebOpen)
            //{
            //    int errorCode2 = StringManager.This().Load();
            //    if (errorCode2 != 0)
            //    {
            //        ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode2, "StringManager Load");
            //        return errorCode2;
            //    }
            //}
            int errorCode3 = WorldMarketOptionManager.This().open(serverType);
            if (errorCode3 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode3, "WorldMarketOptionManager open");
                return errorCode3;
            }
            int errorCode4 = VariedPriceInfoManager.This().open(serverType);
            if (errorCode4 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode4, "VariedPriceInfoManager open");
                return errorCode4;
            }
            if (ServerType.eView == serverType)
            {
                int price = VariedPriceInfoManager.This().initCalculatePrice();
                if (price != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), price, "VariedPriceInfoManager initCalculatePrice");
                    return price;
                }
            }
            int errorCode5 = ItemInfoManager.This().open(serverType);
            if (errorCode5 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode5, "ItemInfoManager open");
                return errorCode5;
            }
            if (ServerType.eProcess == serverType)
            {
                int errorCode6 = TickCountManager.This().open(serverType);
                if (errorCode6 != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode6, "TickCountManager open");
                    return errorCode6;
                }
                int errorCode7 = VariedTradeCountManager.This().open(serverType);
                if (errorCode7 != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode7, "VariedTradeCountManager open");
                    return errorCode7;
                }
            }
            if (ServerType.eView == serverType)
            {
                int errorCode8 = BiddingInfoManager.This().open(serverType);
                if (errorCode8 != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode8, "BiddingInfoManager open");
                    return errorCode8;
                }
                int errorCode9 = WorldMarketItemInfoManager.This().open(serverType);
                if (errorCode9 != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode9, "WorldMarketItemInfoManager open");
                    return errorCode9;
                }
                int errorCode10 = WorldMarketServantInfoManager.This().open(serverType);
                if (errorCode10 != 0)
                {
                    ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode10, "WorldMarketServantInfoManager open");
                    return errorCode10;
                }
            }
            int errorCode11 = CategoryInfoManager.This().open(serverType);
            if (errorCode11 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode11, "CategoryInfoManager open");
                return errorCode11;
            }
            int errorCode12 = FamilySkillManager.This().open(serverType);
            if (errorCode12 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), errorCode12, "FamilySkillManager open");
                return errorCode12;
            }
            lock (ServerControlManager._locker)
                ServerControlManager._dataOpenType = ServerLoading.eOpen;
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "ServerControlManager " + this.getConvertServerName(serverType), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public bool IsLoadComplete() => ServerControlManager._isLoadComplete;

        public void LoadComplete(ServerType serverType)
        {
            lock (ServerControlManager._locker)
                ServerControlManager._isLoadComplete = true;
            ServerLogManager.serverLogWrite(ServerLogType.eOpen, "ServerControlManager " + this.getConvertServerName(serverType) + " Service Start!!!");
        }

        public bool IsDataLoad() => ServerControlManager._dataOpenType == ServerLoading.eOpen;

        public int DataUpdateByRepository(ServerType serverType)
        {
            if (ServerType.eProcess != serverType)
            {
                ServerLogManager.serverLogWrite(ServerLogType.eImpossible, "ServerControlManager " + this.getConvertServerName(serverType) + " DataUpdateByRepository");
                return -1;
            }
            if (!this.IsDataLoad())
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, "ServerControlManager " + this.getConvertServerName(serverType) + " DataUpdateByRepository");
                return -2;
            }
            bool flag = false;
            TradeMarketServerInfo serverInfo = WorldMarketServerInfoManager.This().getServerInfo();
            if (serverInfo != null)
            {
                if (serverType != serverInfo._serverType && serverInfo._serverType != ServerType.eAll)
                {
                    LogUtil.WriteLog(string.Format("서버 타입과 맞지 않는 타이머를 설정하려고 합니다. 서버타입 = {0}, 설정한 서버 타입 = {1}", (object)serverType, (object)serverInfo._serverType), "ERROR");
                    return -2;
                }
                flag = serverInfo._setTimer;
            }
            if (!flag)
            {
                LogUtil.WriteLog("SetTimer가 false 이므로 DataUpdateByRepository를 실행하지 않습니다.", "ERROR");
                return 0;
            }
            lock (ServerControlManager._locker)
            {
                if (ServerLoading.eOpen == ServerControlManager._dbUpdateType)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, "ServerControlManager " + this.getConvertServerName(serverType) + " DataUpdateByRepository");
                    return 0;
                }
                if (ServerLoading.eLoading == ServerControlManager._dbUpdateType)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eLoading, "ServerControlManager " + this.getConvertServerName(serverType) + " DataUpdateByRepository");
                    return 0;
                }
                ServerControlManager._dbUpdateType = ServerLoading.eLoading;
            }
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "ServerControlManager " + this.getConvertServerName(serverType) + " DataUpdateByRepository");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int repositoryXxx1 = ItemInfoManager.This().updateItemInfoToRepositoryXXX();
            if (repositoryXxx1 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), repositoryXxx1 - 100, "updateItemInfoToRepositoryXXX open");
                return repositoryXxx1 - 100;
            }
            int repositoryXxx2 = TickCountManager.This().updateTickCountToRepositoryXXX();
            if (repositoryXxx2 != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), repositoryXxx2 - 200, "updateTickCountToRepositoryXXX open");
                return repositoryXxx2 - 200;
            }
            int num = WorldMarketOptionManager.This().updateRingBuffRateXXX();
            if (num != 0)
            {
                ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), num - 300, "updateRingBuffRateXXX open");
                return num - 300;
            }
            lock (ServerControlManager._locker)
                ServerControlManager._dbUpdateType = ServerLoading.eOpen;
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "ServerControlManager " + this.getConvertServerName(serverType) + " DataUpdateByRepository", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int TimerOpen(ServerType serverType)
        {
            if (ServerType.eProcess != serverType && ServerType.eGame != serverType)
            {
                ServerLogManager.serverLogWrite(ServerLogType.eImpossible, "ServerControlManager " + this.getConvertServerName(serverType) + " TimerOpen");
                return -1;
            }
            if (!this.IsDataLoad())
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, "ServerControlManager " + this.getConvertServerName(serverType) + " TimerOpen");
                return -2;
            }
            int num = TimerManager.This().Open(serverType);
            if (num == 0)
                return 0;
            ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), num - 100, "TimerManager open");
            return num - 100;
        }

        public int dataInit(ServerType serverType)
        {
            if (ServerType.eProcess != serverType && ServerType.eGame != serverType)
            {
                ServerLogManager.serverLogWrite(ServerLogType.eImpossible, "ServerControlManager " + this.getConvertServerName(serverType) + " dataInit");
                return -1;
            }
            if (!this.IsDataLoad())
            {
                ServerLogManager.serverLogWrite(ServerLogType.eNotOpen, "ServerControlManager " + this.getConvertServerName(serverType) + " dataInit");
                return -2;
            }
            int num = HistoryManager.This().Open(serverType);
            if (num == 0)
                return 0;
            ServerLogManager.serverErrorLogWrite(nameof(ServerControlManager), num - 100, "dataInit complete fail");
            return num - 100;
        }

        private string getConvertServerName(ServerType serverType)
        {
            string convertServerName;
            switch (serverType)
            {
                case ServerType.eView:
                    convertServerName = "ViewServer";
                    break;
                case ServerType.eGame:
                    convertServerName = "GameServer";
                    break;
                case ServerType.eProcess:
                    convertServerName = "ProcessServer";
                    break;
                default:
                    convertServerName = "Nothing";
                    break;
            }
            return convertServerName;
        }
    }
}
