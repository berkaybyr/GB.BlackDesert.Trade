// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.TickCountManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class TickCountManager
    {
        private static volatile TickCountManager _singleton;
        private static object _locker = new object();
        private Dictionary<int, int> _tickCountList;
        private List<int> _mainGroupList;
        private bool _isOpen;
        private const string _managerName = "TickCountManager";

        public TickCountManager()
        {
            this._tickCountList = new Dictionary<int, int>();
            this._mainGroupList = new List<int>();
            this._isOpen = false;
        }

        public static TickCountManager This()
        {
            if (TickCountManager._singleton == null)
            {
                lock (TickCountManager._locker)
                {
                    if (TickCountManager._singleton == null)
                        TickCountManager._singleton = new TickCountManager();
                }
            }
            return TickCountManager._singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (TickCountManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(TickCountManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(TickCountManager));
                stopwatch.Start();
                TickCountList tickCountList = new TickCountList();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("/" + ConstantMgr._serviceProject + "WorldTradeMarketItemData/" + ConstantMgr._serviceType, "ItemMarketTickCount.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("ItemMarketTickCount") == 0 && XmlNodeType.Element == xmlFile.NodeType && xmlFile.MoveToFirstAttribute())
                        {
                            int key = 0;
                            int num = 0;
                            do
                            {
                                string name = xmlFile.Name;
                                if (name.CompareTo("MainGroupNo") == 0)
                                    key = Convert.ToInt32(xmlFile.Value);
                                else if (name.CompareTo("NeedTickForUpdate") == 0)
                                    num = Convert.ToInt32(xmlFile.Value);
                            }
                            while (xmlFile.MoveToNextAttribute());
                            this._tickCountList.Add(key, num);
                            this._mainGroupList.Add(key);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog("TickCountManager Load XML Fail Exception=" + ex.ToString(), "ERROR");
                }
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    ObjectParameter rv = new ObjectParameter("rv", typeof(int));
                    ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
                    try
                    {
                        tickCountList.list = ((IEnumerable<uspListTickCount_Result>)tradeWebDb.uspListTickCount(symNo, rv)).ToList<uspListTickCount_Result>();
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog("uspListTickCount open Exception : " + ex.ToString(), "ERROR");
                        return -1;
                    }
                }
                if (this._tickCountList.Count != tickCountList.list.Count)
                {
                    int count = this._tickCountList.Count;
                    string str1 = count.ToString();
                    count = tickCountList.list.Count;
                    string str2 = count.ToString();
                    LogUtil.WriteLog(string.Format("TickCountManager UpdateTick Count Fail xmlCount : {0}  DB Count : {1} ", (object)str1, (object)str2), "WARN");
                    return -2;
                }
                List<int> allowMainGroup = WorldMarketServerInfoManager.This().getAllowMainGroup();
                if (allowMainGroup == null)
                {
                    LogUtil.WriteLog(string.Format("[Http Info]TickCountManager getAllowMainGroup is  Empty"), "WARN");
                    return -3;
                }
                foreach (uspListTickCount_Result listTickCountResult in tickCountList.list)
                {
                    uspListTickCount_Result info = listTickCountResult;
                    if (!allowMainGroup.Exists((Predicate<int>)(x => x == info.C_mainGroupNo)))
                        this._mainGroupList.Remove(info.C_mainGroupNo);
                }
                if (this._mainGroupList.Count == 0)
                {
                    LogUtil.WriteLog(string.Format("[Http Info]TickCountManager _mainGroupList is  Empty"), "WARN");
                    return -5;
                }
                foreach (int mainGroup in this._mainGroupList)
                    LogUtil.WriteLog(string.Format("[Http Info]TickCountManager Init GroupNo : {0} ", (object)mainGroup.ToString()), "INFO");
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(TickCountManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int updateTickCountToRepositoryXXX()
        {
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "TickCountManager updateTickCountToRepositoryXXX");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Dictionary<int, int> dictionary = new Dictionary<int, int>((IDictionary<int, int>)this._tickCountList);
            TickCountList tickCountList = new TickCountList();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    tickCountList.list = ((IEnumerable<uspListTickCount_Result>)tradeWebDb.uspListTickCount(symNo, rv)).ToList<uspListTickCount_Result>();
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspListTickCount Exception : {0}", (object)ex.ToString()), "ERROR");
                    return -1;
                }
            }
            if (this._tickCountList.Count != tickCountList.list.Count)
            {
                int count = this._tickCountList.Count;
                string str1 = count.ToString();
                count = tickCountList.list.Count;
                string str2 = count.ToString();
                LogUtil.WriteLog(string.Format("updateTickCountToRepositoryXXX Fail xmlCount : {0}  DB Count : {1} ", (object)str1, (object)str2), "WARN");
                return -3;
            }
            foreach (uspListTickCount_Result listTickCountResult in tickCountList.list)
            {
                int cMainGroupNo = listTickCountResult.C_mainGroupNo;
                if (this._tickCountList.ContainsKey(cMainGroupNo) && listTickCountResult.C_updateTickCount == this._tickCountList[cMainGroupNo])
                    dictionary.Remove(cMainGroupNo);
            }
            foreach (KeyValuePair<int, int> keyValuePair in dictionary)
            {
                int key = keyValuePair.Key;
                int num = keyValuePair.Value;
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    try
                    {
                        tradeWebDb.uspSetUpdateTickCount(new int?(key), new int?(num), symNo, rv);
                        int int32 = Convert.ToInt32(rv.Value);
                        if (int32 != 0)
                            LogUtil.WriteLog(string.Format("[DB Error] uspListWorldTradeMarketCommand(), rv({0})", (object)int32), "WARN");
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("uspListTickCount Exception : {0}", (object)ex.ToString()), "ERROR");
                        return -2;
                    }
                }
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "TickCountManager updateTickCountToRepositoryXXX", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public void updateTickCountXXX()
        {
            List<int> intList = new List<int>();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            ObjectParameter isUpdatePrice = new ObjectParameter("isUpdatePrice", typeof(bool));
            foreach (int mainGroup in this._mainGroupList)
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    try
                    {
                        tradeWebDb.uspIncreaseTickCount(new int?(mainGroup), isUpdatePrice, symNo, rv);
                        int int32 = Convert.ToInt32(rv.Value);
                        if (int32 != 0)
                            LogUtil.WriteLog(string.Format("[DB Error] uspIncreaseTickCount({0}), rv({1})", (object)mainGroup, (object)int32), "WARN");
                        else if (Convert.ToBoolean(isUpdatePrice.Value))
                            intList.Add(mainGroup);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("uspIncreaseTickCount Exception : {0}", (object)ex.ToString()), "ERROR");
                    }
                }
            }
            foreach (int mainGroupNo in intList)
                this.updatePriceWorldMarketXXX(mainGroupNo);
        }

        public void updatePriceWorldMarketXXX(int mainGroupNo)
        {
            TradeMarketListAccumulateTrade listAccumulateTrade = new TradeMarketListAccumulateTrade();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            long beforeEnchantPrice = 0;
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    listAccumulateTrade.list = ((IEnumerable<uspListWorldMarketAccumulateTrade_Result>)tradeWebDb.uspListWorldMarketAccumulateTrade(new int?(mainGroupNo), symNo, rv)).ToList<uspListWorldMarketAccumulateTrade_Result>();
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspListWorldMarketAccumulateTrade Exception : {0}", (object)ex.ToString()), "ERROR");
                    return;
                }
            }
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                GroupPriceChangerManager.This().clear();
                GroupWeaponPriceChangerManager.This().clear();
                foreach (uspListWorldMarketAccumulateTrade_Result record in listAccumulateTrade.list)
                {
                    TradeMarketItemInfo info = ItemInfoManager.This().getInfo(record.C_mainKey, record.C_subKey);
                    if (!info.isValid())
                    {
                        beforeEnchantPrice = 0L;
                    }
                    else
                    {
                        long passBiddingCount = 0;
                        long worldMarketPricePoint = 0;
                        VariedPriceInfoManager.This().getWorldMarketPassCount(record.C_pricePerOne, ref passBiddingCount, ref worldMarketPricePoint);
                        if (passBiddingCount == 0L || worldMarketPricePoint == 0L)
                        {
                            beforeEnchantPrice = 0L;
                            LogUtil.WriteLog(string.Format("getWorldMarketPassCount({0}, {1}),  Error pricePerOne {2} ", (object)passBiddingCount, (object)worldMarketPricePoint, (object)record.C_pricePerOne), "WARN");
                        }
                        else if (0L < record.C_priceGroupKey)
                        {
                            GroupWeaponPriceChangerManager.This().add(record, info);
                            beforeEnchantPrice = 0L;
                        }
                        else
                        {
                            long cPricePerOne = record.C_pricePerOne;
                            bool flag = beforeEnchantPrice != 0L && beforeEnchantPrice < cPricePerOne;
                            if (record.C_sumTradeCount < info._tradeCountToUpdate && record.C_accumulateTickCount < worldMarketPricePoint && record.C_accumulateBiddingCount < passBiddingCount && !flag)
                            {
                                if (info.hasPriceGroup())
                                {
                                    GroupPriceChangerManager.This().add(record, record.C_pricePerOne, record.C_pricePerOne);
                                    TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                }
                                else
                                {
                                    try
                                    {
                                        tradeWebDb.uspUpdateWorldMarketPassCount(new int?(record.C_keyType), new int?(record.C_mainKey), new int?(record.C_subKey), new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv);
                                        int int32 = Convert.ToInt32(rv.Value);
                                        if (int32 != 0)
                                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, rv - {3}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey, (object)int32), "WARN");
                                    }
                                    catch (Exception ex)
                                    {
                                        LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPassCount Exception : {0}", (object)ex.ToString()), "ERROR");
                                    }
                                    TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                }
                            }
                            else
                            {
                                long num1 = (long)((double)cPricePerOne * (1.0 - WorldMarketOptionManager.This().BiddingRatio));
                                long num2 = (long)((double)cPricePerOne * (1.0 + WorldMarketOptionManager.This().BiddingRatio));
                                if (num1 < info._realMinPrice)
                                    num1 = info._realMinPrice;
                                if (info._realMaxPrice < num2)
                                    num2 = info._realMaxPrice;
                                long newPrice;
                                if (info._tradeCountToUpdate <= record.C_sumTradeCount)
                                    newPrice = (long)((double)record.C_sumTradePrice / (double)record.C_sumTradeCount);
                                else if (worldMarketPricePoint <= record.C_accumulateTickCount || passBiddingCount <= record.C_accumulateBiddingCount || flag)
                                {
                                    if (record.C_sumTradeCount == 0L)
                                    {
                                        int enchantMaxGroup = ItemInfoManager.This().getEnchantMaxGroup(record.C_mainKey, info._enchantGroup);
                                        BiddingPriceList biddingPriceList = new BiddingPriceList();
                                        try
                                        {
                                            biddingPriceList.list = ((IEnumerable<uspListBiddingPrice_Result>)tradeWebDb.uspListBiddingPrice(new int?(record.C_keyType), new int?(record.C_mainKey), new int?(record.C_subKey), new int?(enchantMaxGroup), new double?(WorldMarketOptionManager.This().BiddingRatio), new long?(record.C_pricePerOne), symNo, rv)).ToList<uspListBiddingPrice_Result>();
                                        }
                                        catch (Exception ex)
                                        {
                                            TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                            LogUtil.WriteLog(string.Format("uspListBiddingPrice Exception : {0}", (object)ex.ToString()), "ERROR");
                                            continue;
                                        }
                                        if (biddingPriceList.list != null && 0 < biddingPriceList.list.Count)
                                        {
                                            long num3 = 0;
                                            long num4 = 0;
                                            foreach (uspListBiddingPrice_Result biddingPriceResult in biddingPriceList.list)
                                            {
                                                if (0L < num3 + biddingPriceResult.C_pricePerOne * biddingPriceResult.C_leftCount)
                                                {
                                                    num3 += biddingPriceResult.C_pricePerOne * biddingPriceResult.C_leftCount;
                                                    num4 += biddingPriceResult.C_leftCount;
                                                }
                                                else
                                                    break;
                                            }
                                            newPrice = (long)((double)num3 / (double)num4);
                                        }
                                        else
                                            newPrice = record.C_pricePerOne;
                                    }
                                    else
                                        newPrice = (long)((double)record.C_sumTradePrice / (double)record.C_sumTradeCount);
                                }
                                else
                                {
                                    TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                    LogUtil.WriteLog(string.Format("newPrice fail keyType - {0}, mainKey - {1}, subKey - {2}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey), "WARN");
                                    continue;
                                }
                                long nextGraphPrice = newPrice;
                                if (num1 > newPrice || newPrice > num2)
                                {
                                    if (newPrice < num1)
                                        newPrice = num1;
                                    if (num2 < newPrice)
                                        newPrice = num2;
                                }
                                long price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                                if (price == 0L)
                                {
                                    TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                    LogUtil.WriteLog(string.Format("calculatePrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey, (object)price), "WARN");
                                }
                                else
                                {
                                    TickCountCommon.checkAndUpdateBeforePrice(beforeEnchantPrice, ref price);
                                    if (info.hasPriceGroup())
                                    {
                                        GroupPriceChangerManager.This().add(record, price, nextGraphPrice);
                                        TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                    }
                                    else
                                    {
                                        FluctuationType fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
                                        long fluctuationPrice = 0;
                                        TickCountCommon.fluctuationCalc(price, cPricePerOne, ref fluctuationType, ref fluctuationPrice);
                                        try
                                        {
                                            tradeWebDb.uspUpdateWorldMarketPrice(new int?(record.C_keyType), new int?(record.C_mainKey), new int?(record.C_subKey), new long?(price), new long?(nextGraphPrice), new byte?((byte)fluctuationType), new long?(fluctuationPrice), new long?(0L), symNo, rv);
                                            int int32 = Convert.ToInt32(rv.Value);
                                            if (int32 != 0)
                                            {
                                                LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}, rv - {4}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey, (object)price, (object)int32), "WARN");
                                                TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                            }
                                            else
                                                TickCountCommon.enchantLevelCalc(price, record.C_subKey, ref beforeEnchantPrice);
                                        }
                                        catch (Exception ex)
                                        {
                                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice Exception : {0}", (object)ex.ToString()), "ERROR");
                                            TickCountCommon.enchantLevelCalc(cPricePerOne, record.C_subKey, ref beforeEnchantPrice);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                GroupPriceChangerManager.This().update();
                foreach (GroupPriceChanger changer in GroupPriceChangerManager.This().changerList)
                {
                    if (changer.priceRatio != changer.nextPriceRatio)
                    {
                        long cMaxTradeCount = changer._record.C_maxTradeCount;
                        FluctuationType fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
                        long fluctuationPrice = 0;
                        TickCountCommon.fluctuationCalc(changer.nextPrice, changer.price, ref fluctuationType, ref fluctuationPrice);
                        try
                        {
                            uspListWorldMarketAccumulateTrade_Result record = changer._record;
                            tradeWebDb.uspUpdateWorldMarketPrice(new int?(record.C_keyType), new int?(record.C_mainKey), new int?(record.C_subKey), new long?(changer.nextPrice), new long?(changer.nextGraphPrice), new byte?((byte)fluctuationType), new long?(fluctuationPrice), new long?(cMaxTradeCount), symNo, rv);
                            int int32 = Convert.ToInt32(rv.Value);
                            if (int32 != 0)
                                LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}, rv - {4}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey, (object)changer.nextPrice, (object)int32), "WARN");
                        }
                        catch (Exception ex)
                        {
                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice Exception : {0}", (object)ex.ToString()), "ERROR");
                        }
                    }
                    else
                    {
                        try
                        {
                            uspListWorldMarketAccumulateTrade_Result record = changer._record;
                            tradeWebDb.uspUpdateWorldMarketPassCount(new int?(record.C_keyType), new int?(record.C_mainKey), new int?(record.C_subKey), new double?(WorldMarketOptionManager.This().BiddingRatio), symNo, rv);
                            int int32 = Convert.ToInt32(rv.Value);
                            if (int32 != 0)
                                LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPrice fail keyType - {0}, mainKey - {1}, subKey - {2}, rv - {3}", (object)record.C_keyType, (object)record.C_mainKey, (object)record.C_subKey, (object)int32), "WARN");
                        }
                        catch (Exception ex)
                        {
                            LogUtil.WriteLog(string.Format("uspUpdateWorldMarketPassCount Exception : {0}", (object)ex.ToString()), "ERROR");
                        }
                    }
                }
                GroupWeaponPriceChangerManager.This().update();
                LogUtil.WriteLog(string.Format("updatePriceWorldMarketXXX complete mainGroupNo:{0},  ", (object)mainGroupNo), "INFO");
            }
        }

        public bool isExistsMainGroupNo(int mainGroupNo) => this._tickCountList.ContainsKey(mainGroupNo);

        public List<int> getMainGroupListXXX() => this._mainGroupList;

        public void updatePriceTargetXXX(bool isIncrease, int keyType, int mainKey, int subKey)
        {
            ObjectParameter pricePerOne = new ObjectParameter("pricePerOne", typeof(long));
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            using (TradeWebDB tradeWebDb = new TradeWebDB())
            {
                try
                {
                    tradeWebDb.uspGetItemPrice(new int?(keyType), new int?(mainKey), new int?(subKey), pricePerOne, symNo, rv);
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("updatePriceTargetXXX Exception : {0}", (object)ex.ToString()), "ERROR");
                    return;
                }
            }
            int int32_1 = Convert.ToInt32(rv.Value);
            if (int32_1 != 0)
            {
                LogUtil.WriteLog(string.Format("[DB Error] updatePriceTargetXXX(), rv({0})", (object)int32_1), "WARN");
            }
            else
            {
                long int64 = Convert.ToInt64(pricePerOne.Value);
                long price;
                FluctuationType fluctuationType;
                long num;
                if (isIncrease)
                {
                    long newPrice = (long)((double)int64 * (1.0 + WorldMarketOptionManager.This().BiddingRatio));
                    price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                    fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Up;
                    num = price - int64;
                }
                else
                {
                    long newPrice = (long)((double)int64 * (1.0 - WorldMarketOptionManager.This().BiddingRatio));
                    price = VariedPriceInfoManager.This().calculatePrice(newPrice);
                    fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Down;
                    num = int64 - price;
                }
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                {
                    try
                    {
                        tradeWebDb.uspUpdateWorldMarketPrice(new int?(keyType), new int?(mainKey), new int?(subKey), new long?(price), new long?(price), new byte?((byte)fluctuationType), new long?(num), new long?(0L), symNo, rv);
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(string.Format("updatePriceTargetXXX Exception : {0}", (object)ex.ToString()), "ERROR");
                        return;
                    }
                }
                int int32_2 = Convert.ToInt32(rv.Value);
                if (int32_2 == 0)
                    return;
                LogUtil.WriteLog(string.Format("updatePriceTargetXXX fail keyType - {0}, mainKey - {1}, subKey - {2}, newPrice - {3}, rv - {4}", (object)keyType, (object)mainKey, (object)subKey, (object)price, (object)int32_2), "WARN");
            }
        }
    }
}
