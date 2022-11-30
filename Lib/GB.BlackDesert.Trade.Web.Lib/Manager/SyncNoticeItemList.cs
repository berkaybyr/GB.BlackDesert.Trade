// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.SyncNoticeItemList
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Objects;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class SyncNoticeItemList
    {
        private static object _locker = new object();
        private static bool _flag = false;
        private static long _updateTime;

        public static void Excute(object state)
        {
            lock (SyncNoticeItemList._locker)
            {
                if (SyncNoticeItemList._flag)
                    return;
                SyncNoticeItemList._flag = true;
            }
            try
            {
                SyncNoticeItemList.syncNoticeItemList();
                ServerLogManager.serverLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]SyncNoticeItemList", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]SyncNoticeItemList Exception={1}", state, (object)ex.ToString()), "ERROR");
            }
            lock (SyncNoticeItemList._locker)
                SyncNoticeItemList._flag = false;
        }

        private static int syncNoticeItemList()
        {
            CommonResult commonResult = new CommonResult();
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            string errorMsg = string.Empty;
            string relResult = string.Empty;
            if (SyncNoticeItemList._updateTime == 0L)
                SyncNoticeItemList._updateTime = CommonModule.ConvertUnixTime(DateTime.UtcNow);
            commonResult.resultCode = CommonModule.HttpRequest(ConstantMgr._processDomain + "/SyncNoticeItemListProcess", JsonConvert.SerializeObject((object)SyncNoticeItemList._updateTime), "POST", "text/json", out relResult, out errorMsg);
            if (commonResult.resultCode != 0)
            {
                LogUtil.WriteLog("[Http Error]syncNoticeItemList(" + JsonConvert.SerializeObject((object)SyncNoticeItemList._updateTime) + ") - HttpRequest SyncNoticeItemListProcess errorMsg : " + errorMsg + " - HttpUrl : " + ConstantMgr._processDomain + "/SyncNoticeItemListProcess", "WARN");
                commonResult.resultCode = 2;
                commonResult.resultMsg = CommonModule.GetResourceValue("TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_HttpException");
                return commonResult.resultCode;
            }
            CommonDBResult<uspListNoticeItem_Result> commonDbResult = JsonConvert.DeserializeObject<CommonDBResult<uspListNoticeItem_Result>>(relResult);
            if (commonDbResult.resultCode != 0)
            {
                LogUtil.WriteLog("[Http Exception] syncNoticeItemList() Exception : " + commonDbResult.resultMsg, "WARN");
                return commonDbResult.resultCode;
            }
            if (commonDbResult.list.Count == 0)
            {
                LogUtil.WriteLog(string.Format("[DB INFO] syncNoticeItemList() updateTime : {0}", (object)SyncNoticeItemList._updateTime), "INFO");
                return 0;
            }
            List<string> stringList = new List<string>();
            foreach (ConnectionStringSettings connectionString in (ConfigurationElementCollection)ConfigurationManager.ConnectionStrings)
            {
                if (connectionString.Name.ToLower().IndexOf("SA_BETA_GAMEDB_0002") == 0)
                    stringList.Add(connectionString.Name);
            }
            foreach (string name in stringList)
            {
                foreach (uspListNoticeItem_Result noticeItemResult in commonDbResult.list)
                {
                    try
                    {
                        using (SA_BETA_GAMEDB_0002 SA_BETA_GAMEDB_0002 = new SA_BETA_GAMEDB_0002()) //name
                            SA_BETA_GAMEDB_0002.uspInsertToNoticeItem(new long?(noticeItemResult.C_registTimeStamp), new int?(noticeItemResult.C_keyType), new int?(noticeItemResult.C_mainKey), new int?(noticeItemResult.C_subKey), new long?(noticeItemResult.C_price), new long?(noticeItemResult.C_changedValue), new short?(noticeItemResult.C_noticeType), rv, symNo);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("[DB Exception] reqSyncNoticeItemList() - uspInsertToNoticeItem() Exception : {0} , symNo : {1}", (object)ex.ToString(), (object)symNo), "ERROR");
                    }
                }
            }
            SyncNoticeItemList._updateTime = commonDbResult.list[commonDbResult.list.Count - 1].C_registTimeStamp;
            return 0;
        }
    }
}
