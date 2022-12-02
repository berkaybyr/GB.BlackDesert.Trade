using BlackDesert.TradeMarket.Application.Xml;
using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
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
            _emptyStockInfo = new TradeMarketItemInfo();
            _itemInfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo>();
            _itemEnchantMaxLevelList = new Dictionary<int, int>();
            _itemEnchantMaxGrouplList = new Dictionary<KeyValuePair<int, int>, int>();
            _marketPriceGroupList = new Dictionary<long, MarketPriceGroup>();
            _servantInfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo>();
            _isOpen = false;
        }

        public static ItemInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new ItemInfoManager();
                }
            }
            return _singleton;
        }

        public bool isOpen() => _isOpen;

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
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
                                            maxRegisterForWorldMarket = Convert.ToInt32(xmlFile.Value);
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
                                LogUtil.WriteLog(string.Format("ItemInfoManager fail read Attribute - {0}", ex.ToString()), "ERROR");
                                return -1;
                            }
                            TradeMarketItemInfo tradeMarketItemInfo = new TradeMarketItemInfo(keyType, itemKey, enchantLevel, mainGroupNo, subGroupNo, enchantAddPercent, maxPrice, minPrice, basePrice, isEnchantable, enchantGroup, enchantNeedCount, isPersonalTrade, enchantMaterialKey, weight, maxStackCount, tradeCountToUpdate, accumulatePassCount, maxRegisterForWorldMarket, noticeAbleItemForWorldMarket, grade, marketPriceGroup, isForceDisplay, maxPriceNew, minPriceNew);
                            switch ((KeyType)keyType)
                            {
                                case KeyType.eItem:
                                    KeyValuePair<int, int> key1 = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey);
                                    _itemInfoList[key1] = tradeMarketItemInfo;
                                    if (!_itemEnchantMaxLevelList.ContainsKey(tradeMarketItemInfo._mainKey))
                                        _itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
                                    else if (_itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] < tradeMarketItemInfo._subKey)
                                        _itemEnchantMaxLevelList[tradeMarketItemInfo._mainKey] = tradeMarketItemInfo._subKey;
                                    KeyValuePair<int, int> key2 = new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._enchantGroup);
                                    if (!_itemEnchantMaxGrouplList.ContainsKey(key2))
                                        _itemEnchantMaxGrouplList[key2] = tradeMarketItemInfo._subKey;
                                    else if (_itemEnchantMaxGrouplList[key2] < tradeMarketItemInfo._subKey)
                                        _itemEnchantMaxGrouplList[key2] = tradeMarketItemInfo._subKey;
                                    if (tradeMarketItemInfo._marketPriceGroup != 0L)
                                    {
                                        if (!_marketPriceGroupList.ContainsKey(tradeMarketItemInfo._marketPriceGroup))
                                        {
                                            _marketPriceGroupList.Add(tradeMarketItemInfo._marketPriceGroup, new MarketPriceGroup());
                                            _marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(key1);
                                            continue;
                                        }
                                        if (!_marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Contains(key1))
                                        {
                                            _marketPriceGroupList[tradeMarketItemInfo._marketPriceGroup]._enchantKeyList.Add(key1);
                                            continue;
                                        }
                                        continue;
                                    }
                                    continue;
                                case KeyType.eServant:
                                    _servantInfoList[new KeyValuePair<int, int>(tradeMarketItemInfo._mainKey, tradeMarketItemInfo._subKey)] = tradeMarketItemInfo;
                                    continue;
                                default:
                                    LogUtil.WriteLog(string.Format("ItemInfoManager fail load xml - KeyType Fail : {0}", keyType), "WARN");
                                    return -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("ItemInfoManager fail load xml - {0}", ex.ToString()), "ERROR");
                    return -1;
                }
                _isOpen = true;
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
            lock (_locker)
            {
                try
                {
                    using (SA_BETA_TRADEDB_0002 SA_BETA_TRADEDB_0002 = new SA_BETA_TRADEDB_0002())
                    {
                        foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in getItemListXXX())
                        {
                            if (keyValuePair.Value._enchantGroup == keyValuePair.Value._subKey)
                            {
                                long num = 0;
                                if (keyValuePair.Value.hasPriceGroup() && WorldMarketOptionManager.This().getCashGroupNo() != keyValuePair.Value._mainGroupNo)
                                    num = keyValuePair.Value._marketPriceGroup;
                                SA_BETA_TRADEDB_0002.uspUpdateItemInfo(new int?(keyValuePair.Value._keyType), new int?(keyValuePair.Value._mainKey), new int?(keyValuePair.Value._subKey), new int?(keyValuePair.Value._mainGroupNo), new int?(keyValuePair.Value._subGroupNo), new long?(0L), new long?(0L), new long?(0L), new long?(keyValuePair.Value._basePrice), new long?(keyValuePair.Value._maxPrice), new long?(keyValuePair.Value._minPrice), new long?(keyValuePair.Value._realMaxPrice), new long?(keyValuePair.Value._realMinPrice), new long?(num), new bool?(keyValuePair.Value._isForceDisplay), symNo, rv);
                            }
                        }
                        foreach (KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo> keyValuePair in getServantListXXX())
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
                    LogUtil.WriteLog(string.Format("uspUpdateItemInfo Exception : {0}", ex.ToString()), "ERROR");
                    return -2;
                }
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, "ItemInfoManager updateItemInfoToRepositoryXXX", stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public stockInfoListWrapper getItemListXXX() => new stockInfoListWrapper(_itemInfoList);

        public int getMaxEnchantLevel(int mainKey)
        {
            int maxEnchantLevel = 0;
            if (_itemEnchantMaxLevelList.ContainsKey(mainKey))
                maxEnchantLevel = _itemEnchantMaxLevelList[mainKey];
            return maxEnchantLevel;
        }

        public int getEnchantMaxGroup(int mainKey, int groupLevel)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(mainKey, groupLevel);
            int enchantMaxGroup = 0;
            if (_itemEnchantMaxGrouplList.ContainsKey(key))
                enchantMaxGroup = _itemEnchantMaxGrouplList[key];
            return enchantMaxGroup;
        }

        public TradeMarketItemInfo getInfo(int itemKey, int enchantLevel)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(itemKey, enchantLevel);
            return !_itemInfoList.ContainsKey(key) ? _emptyStockInfo : _itemInfoList[key];
        }

        public stockInfoListWrapper getServantListXXX() => new stockInfoListWrapper(_servantInfoList);

        public TradeMarketItemInfo getServantInfo(int servantMainKey, int subKey)
        {
            KeyValuePair<int, int> key = new KeyValuePair<int, int>(servantMainKey, subKey);
            return !_servantInfoList.ContainsKey(key) ? _emptyStockInfo : _servantInfoList[key];
        }
    }
}
