// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.ItemInfoManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Models;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Xml;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class ItemInfoManager
    {
        private static volatile ItemInfoManager _singleton;
        private static object _locker = new object();
        private readonly TradeMarketItemInfo _emptyStockInfo;
        private Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _itemInfoList;
        private Dictionary<int, int> _itemEnchantMaxLevelList;
        private Dictionary<KeyValuePair<int, int>, int> _itemEnchantMaxGrouplList;
        private Dictionary<long, MarketPriceGroup> _marketPriceGroupList;
        private Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _servantInfoList;
        private bool _isOpen;
        private const string _managerName = "ItemInfoManager";

        public ItemInfoManager()
        {
            this._emptyStockInfo = new TradeMarketItemInfo();
            this._itemInfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo>();
            this._itemEnchantMaxLevelList = new Dictionary<int, int>();
            this._itemEnchantMaxGrouplList = new Dictionary<KeyValuePair<int, int>, int>();
            this._marketPriceGroupList = new Dictionary<long, MarketPriceGroup>();
            this._servantInfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo>();
            this._isOpen = false;
        }

        public static ItemInfoManager This()
        {
            if (ItemInfoManager._singleton == null)
            {
                lock (ItemInfoManager._locker)
                {
                    if (ItemInfoManager._singleton == null)
                        ItemInfoManager._singleton = new ItemInfoManager();
                }
            }
            return ItemInfoManager._singleton;
        }

        public bool isOpen() => this._isOpen;

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (ItemInfoManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(ItemInfoManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(ItemInfoManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("/" + ConstantMgr._serviceProject + "WorldTradeMarketItemData/" + ConstantMgr._serviceType, "WorldTradeMarketItemList.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if ((xmlFile.Name.CompareTo("ItemMarket") == 0 || xmlFile.Name.CompareTo("trademarketiteminfo") == 0) && XmlNodeType.Element == xmlFile.NodeType)
                        {
                            int keyType = 0;
                            int itemKey = 0;
                            int enchantLevel = 0;
                            int mainGroupNo = 0;
                            int subGroupNo = 0;
                            long enchantAddPercent = 0;
                            long basePrice = 0;
                            long maxPrice = 0;
                            long minPrice = 0;
                            long maxPriceNew = 0;
                            long minPriceNew = 0;
                            bool isEnchantable = false;
                            int enchantGroup = 0;
                            long enchantNeedCount = 0;
                            bool isPersonalTrade = false;
                            int enchantMaterialKey = 0;
                            long weight = 0;
                            long maxStackCount = 0;
                            long tradeCountToUpdate = 0;
                            int accumulatePassCount = 0;
                            long maxRegisterForWorldMarket = 0;
                            bool noticeAbleItemForWorldMarket = false;
                            int grade = 0;
                            long marketPriceGroup = 0;
                            bool isForceDisplay = false;
                            try
                            {
                                if (xmlFile.MoveToFirstAttribute())
                                {
                                    do
                                    {
                                        string name = xmlFile.Name;
                                        if (name.CompareTo("KeyType") == 0)
                                            keyType = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("ItemKey") == 0)
                                            itemKey = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("EnchantLevel") == 0)
                                            enchantLevel = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("MainGroupNo") == 0)
                                            mainGroupNo = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("SubGroupNo") == 0)
                                            subGroupNo = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("BasePrice") == 0)
                                            basePrice = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("MinestPercent") == 0)
                                            minPrice = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("MaxestPercent") == 0)
                                            maxPrice = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("MinestPrice") == 0)
                                            minPriceNew = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("MaxestPrice") == 0)
                                            maxPriceNew = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("EnchantAddPercent") == 0)
                                            enchantAddPercent = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("isEnchatable") == 0)
                                            isEnchantable = Convert.ToBoolean(xmlFile.Value);
                                        else if (name.CompareTo("EnchantGroup") == 0)
                                            enchantGroup = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("EnchantNeedCount") == 0)
                                            enchantNeedCount = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("isPersonalTrade") == 0)
                                            isPersonalTrade = Convert.ToBoolean(xmlFile.Value);
                                        else if (name.CompareTo("EnchantMaterialKey") == 0)
                                            enchantMaterialKey = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("Weight") == 0)
                                            weight = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("MaxStackCount") == 0)
                                            maxStackCount = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("TradeCountToUpdate") == 0)
                                            tradeCountToUpdate = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("AccumulatePassCount") == 0)
                                            accumulatePassCount = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("MaxRegisterCountForWorldMarket") == 0)
                                            maxRegisterForWorldMarket = (long)Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("NoticeAbleItemForWorldMarket") == 0)
                                            noticeAbleItemForWorldMarket = Convert.ToBoolean(xmlFile.Value);
                                        else if (name.CompareTo("Grade") == 0)
                                            grade = Convert.ToInt32(xmlFile.Value);
                                        else if (name.CompareTo("MarketPriceGroup") == 0)
                                            marketPriceGroup = Convert.ToInt64(xmlFile.Value);
                                        else if (name.CompareTo("IsForceDisplay") == 0)
                                            isForceDisplay = Convert.ToBoolean(xmlFile.Value);
                                    }
                                    while (xmlFile.MoveToNextAttribute());
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog(string.Format("ItemInfoManager fail read Attribute - {0}", (object)ex.ToString()), "ERROR");
                                return -1;
                            }
                            TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo(keyType, itemKey, enchantLevel, mainGroupNo, subGroupNo, enchantAddPercent, maxPrice, minPrice, basePrice, isEnchantable, enchantGroup, enchantNeedCount, isPersonalTrade, enchantMaterialKey, weight, maxStackCount, tradeCountToUpdate, accumulatePassCount, maxRegisterForWorldMarket, noticeAbleItemForWorldMarket, grade, marketPriceGroup, isForceDisplay, maxPriceNew, minPriceNew);
                            switch ((KeyType)keyType)
                            {
                                case KeyType.eItem:
                                    KeyValuePair<int, int> key1 = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey);
                                    this._itemInfoList[key1] = tradeMarketItemInfo;
                                    if (!this._itemEnchantMaxLevelList.ContainsKey(tradeMarketItemInfo._mainKey))
                                        this._itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
                                    else if (this._itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] < tradeMarketItemInfo._subKey)
                                        this._itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
                                    KeyValuePair<int, int> key2 = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._enchantGroup);
                                    if (!this._itemEnchantMaxGrouplList.ContainsKey(key2))
                                        this._itemEnchantMaxGrouplList[key2] = tradeMarketItemInfo._subKey;
                                    else if (this._itemEnchantMaxGrouplList[key2] < tradeMarketItemInfo._subKey)
                                        this._itemEnchantMaxGrouplList[key2] = tradeMarketItemInfo._subKey;
                                    if (tradeMarketItemInfo._marketPriceGroup != 0L)
                                    {
                                        if (!this._marketPriceGroupList.ContainsKey(tradeMarketItemInfo._marketPriceGroup))
                                        {
                                            this._marketPriceGroupList.Add(tradeMarketItemInfo._marketPriceGroup, new MarketPriceGroup());
                                            this._marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(key1);
                                            continue;
                                        }
                                        if (!this._marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Contains(key1))
                                        {
                                            this._marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(key1);
                                            continue;
                                        }
                                        continue;
                                    }
                                    continue;
                                case KeyType.eServant:
                                    this._servantInfoList[new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey)] = tradeMarketItemInfo;
                                    continue;
                                default:
                                    LogUtil.WriteLog(string.Format("ItemInfoManager fail load xml - KeyType Fail : {0}", (object)keyType), "WARN");
                                    return -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("ItemInfoManager fail load xml - {0}", (object)ex.ToString()), "ERROR");
                    return -1;
                }
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(ItemInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public int updateItemInfoToRepositoryXXX()
        {
            ServerLogManager.serverLogWrite(ServerLogType.eStart, "ItemInfoManager updateItemInfoToRepositoryXXX");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ObjectParameter rv = new ObjectParameter("rv", typeof(int));
            ObjectParameter symNo = new ObjectParameter("symNo", typeof(string));
            TradeMarketListLoadItemInfo listLoadItemInfo = new TradeMarketListLoadItemInfo();
            lock (ItemInfoManager._locker)
            {
                try
                {
                    using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                    {
                        foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in this.getItemListXXX())
                        {
                            if (keyValuePair.Value._enchantGroup == keyValuePair.Value._subKey)
                            {
                                long num = 0;
                                if (keyValuePair.Value.hasPriceGroup() && WorldMarketOptionManager.This().getCashGroupNo() != keyValuePair.Value._mainGroupNo)
                                    num = keyValuePair.Value._marketPriceGroup;
                                SA_BETA_TRADEDB_0002.uspUpdateItemInfo(new int?(keyValuePair.Value._keyType), new int?(keyValuePair.Value._mainKey), new int?(keyValuePair.Value._subKey), new int?(keyValuePair.Value._mainGroupNo), new int?(keyValuePair.Value._subGroupNo), new long?(0L), new long?(0L), new long?(0L), new long?(keyValuePair.Value._basePrice), new long?(keyValuePair.Value._maxPrice), new long?(keyValuePair.Value._minPrice), new long?(keyValuePair.Value._realMaxPrice), new long?(keyValuePair.Value._realMinPrice), new long?(num), new bool?(keyValuePair.Value._isForceDisplay), symNo, rv);
                            }
                        }
                        foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in this.getServantListXXX())
                        {
                            if (keyValuePair.Value._enchantGroup == keyValuePair.Value._subKey)
                            {
                                long num = 0;
                                if (keyValuePair.Value.hasPriceGroup() && WorldMarketOptionManager.This().getCashGroupNo() != keyValuePair.Value._mainGroupNo)
                                    num = keyValuePair.Value._marketPriceGroup;
                                SA_BETA_TRADEDB_0002.uspUpdateItemInfo(new int?(keyValuePair.Value._keyType), new int?(keyValuePair.Value._mainKey), new int?(keyValuePair.Value._subKey), new int?(keyValuePair.Value._mainGroupNo), new int?(keyValuePair.Value._subGroupNo), new long?(0L), new long?(0L), new long?(0L), new long?(keyValuePair.Value._basePrice), new long?(keyValuePair.Value._maxPrice), new long?(keyValuePair.Value._minPrice), new long?(keyValuePair.Value._realMaxPrice), new long?(keyValuePair.Value._realMinPrice), new long?(num), new bool?(keyValuePair.Value._isForceDisplay), symNo, rv);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("uspUpdateItemInfo Exception : {0}", (object)ex.ToString()), "ERROR");
                    return -2;
                }
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "ItemInfoManager updateItemInfoToRepositoryXXX", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public stockInfoListWrapper getItemListXXX() => new stockInfoListWrapper(this._itemInfoList);

        public int getMaxEnchantLevel(int mainKey)
        {
            int maxEnchantLevel = 0;
            if (this._itemEnchantMaxLevelList.ContainsKey(mainKey))
                maxEnchantLevel = this._itemEnchantMaxLevelList[mainKey];
            return maxEnchantLevel;
        }

        public int getEnchantMaxGroup(int mainKey, int groupLevel)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, groupLevel);
            int enchantMaxGroup = 0;
            if (this._itemEnchantMaxGrouplList.ContainsKey(key))
                enchantMaxGroup = this._itemEnchantMaxGrouplList[key];
            return enchantMaxGroup;
        }

        public TradeMarketItemInfo getInfo(int itemKey, int enchantLevel)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(itemKey, enchantLevel);
            return !this._itemInfoList.ContainsKey(key) ? this._emptyStockInfo : this._itemInfoList[key];
        }

        public stockInfoListWrapper getServantListXXX() => new stockInfoListWrapper(this._servantInfoList);

        public TradeMarketItemInfo getServantInfo(int servantMainKey, int subKey)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(servantMainKey, subKey);
            return !this._servantInfoList.ContainsKey(key) ? this._emptyStockInfo : this._servantInfoList[key];
        }
    }
}
