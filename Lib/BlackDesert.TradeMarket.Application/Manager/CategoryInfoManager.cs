using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class CategoryInfoManager
    {
        private static volatile CategoryInfoManager _singleton;
        private static object _locker = new object();
        private Dictionary<int, List<int>> _categoryInfoList;
        private List<KeyValuePair<int, int>> _categoryKeyList;
        private bool _isOpen;
        private const string _managerName = "CategoryInfoManager";

        public CategoryInfoManager()
        {
            _categoryInfoList = new Dictionary<int, List<int>>();
            _categoryKeyList = new List<KeyValuePair<int, int>>();
            _isOpen = false;
        }

        public static CategoryInfoManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new CategoryInfoManager();
                }
            }
            return _singleton;
        }

        public int open(ServerType serverType)
        {
            Stopwatch stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(CategoryInfoManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(CategoryInfoManager));
                stopwatch.Start();
                try
                {
                    XmlReader xmlFile = CommonModule.GetXmlFile("/" + ConstantMgr._serviceProject + "WorldTradeMarketItemData/" + ConstantMgr._serviceType, "WorldTradeMarketCategoryList.xml", serverType);
                    while (xmlFile.Read())
                    {
                        if (xmlFile.Name.CompareTo("categoryinfo") == 0 || xmlFile.Name.CompareTo("WorldTradeMarketCategory") == 0 && xmlFile.NodeType == XmlNodeType.Element)
                        {
                            int key = 0;
                            int num1 = 0;
                            int num2 = 0;
                            try
                            {
                                if (xmlFile.MoveToFirstAttribute())
                                {
                                    do
                                    {
                                        string name = xmlFile.Name;
                                        if (ConstantMgr._serviceProject.Equals("BDO"))
                                        {
                                            if (name.CompareTo("MainCategoryNo") == 0)
                                                key = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("SubCategoryNo") == 0)
                                                num1 = Convert.ToInt32(xmlFile.Value);
                                        }
                                        if (ConstantMgr._serviceProject.Equals("CDO"))
                                        {
                                            if (name.CompareTo("MainCategory") == 0)
                                                key = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("Category") == 0)
                                                num1 = Convert.ToInt32(xmlFile.Value);
                                            else if (name.CompareTo("SubCategory") == 0)
                                                num2 = Convert.ToInt32(xmlFile.Value);
                                        }
                                    }
                                    while (xmlFile.MoveToNextAttribute());
                                }
                            }
                            catch (Exception ex)
                            {
                                LogUtil.WriteLog("CategoryInfoManager fail read Attribute - " + ex.ToString(), "ERROR");
                                return -1;
                            }
                            if (!ConstantMgr._serviceProject.Equals("CDO") || num1 != 0 && num2 == 0)
                            {
                                if (!_categoryInfoList.ContainsKey(key))
                                    _categoryInfoList.Add(key, new List<int>());
                                _categoryInfoList[key].Add(num1);
                                _categoryKeyList.Add(new KeyValuePair<int, int>(key, num1));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(string.Format("CategoryInfoManager fail load xml - {0}", ex.ToString()), "ERROR");
                    return -1;
                }
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(CategoryInfoManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public KeyValuePair<int, int> getNextCategory(ref int currentIndex)
        {
            if (_categoryKeyList.Count <= currentIndex)
                currentIndex = 0;
            KeyValuePair<int, int> categoryKey = _categoryKeyList[currentIndex];
            ++currentIndex;
            return categoryKey;
        }

        public Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>> CategoryList
        {
            get
            {
                Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>> categoryList = new Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>>();
                string empty = string.Empty;
                try
                {
                    foreach (KeyValuePair<int, List<int>> categoryInfo in _categoryInfoList)
                    {
                        int key1 = categoryInfo.Key;
                        KeyValuePair<int, string> key2 = new KeyValuePair<int, string>(key1, StringManager.This().CategoryStringList[string.Format("{0}_0", key1)]);
                        foreach (int key3 in categoryInfo.Value)
                        {
                            string key4 = string.Format("{0}_{1}", key1, key3);
                            if (!StringManager.This().CategoryStringList.ContainsKey(key4))
                            {
                                KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>(key3, "-");
                                if (!categoryList.ContainsKey(key2))
                                    categoryList.Add(key2, new List<KeyValuePair<int, string>>());
                                categoryList[key2].Add(keyValuePair);
                            }
                            else
                            {
                                KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>(key3, StringManager.This().CategoryStringList[key4]);
                                if (!categoryList.ContainsKey(key2))
                                    categoryList.Add(key2, new List<KeyValuePair<int, string>>());
                                categoryList[key2].Add(keyValuePair);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog("CategoryList Exception:" + ex.ToString(), "ERROR");
                    return new Dictionary<KeyValuePair<int, string>, List<KeyValuePair<int, string>>>();
                }
                return categoryList;
            }
        }
    }
}
