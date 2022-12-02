using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class StringManager
    {
        private static Dictionary<string, Dictionary<string, string>> _categoryStringResource;
        private static Dictionary<string, Dictionary<string, string>> _itemStringResource;
        private static volatile StringManager _singleton;
        private static object _locker = new object();
        private bool _isOpen;
        private const string _managerName = "StringManager";

        public StringManager()
        {
            _isOpen = false;
            _categoryStringResource = new Dictionary<string, Dictionary<string, string>>();
            _itemStringResource = new Dictionary<string, Dictionary<string, string>>();
        }

        public static StringManager This()
        {
            if (_singleton == null)
            {
                lock (_locker)
                {
                    if (_singleton == null)
                        _singleton = new StringManager();
                }
            }
            return _singleton;
        }

        public int Load()
        {
            string empty1 = string.Empty;
            string requestUriString = string.Empty;
            string empty2 = string.Empty;
            string empty3 = string.Empty;
            string empty4 = string.Empty;
            string empty5 = string.Empty;
            string empty6 = string.Empty;
            Stopwatch stopwatch = new Stopwatch();
            lock (_locker)
            {
                if (_isOpen)
                {
                    ServerLogManager.ServerLogWrite(ServerLogType.eAlready, nameof(StringManager));
                    return 0;
                }
                ServerLogManager.ServerLogWrite(ServerLogType.eStart, nameof(StringManager));
                stopwatch.Start();
                try
                {
                    string languageList = ConstantMgr._languageList;
                    if (string.IsNullOrEmpty(languageList))
                        return -10;
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    string str1 = languageList;
                    char[] chArray1 = new char[1] { ',' };
                    foreach (string str2 in str1.Split(chArray1))
                    {
                        string end;
                        requestUriString = ConstantMgr._tradeXMLDomain + "/Common/xml/" + ConstantMgr._serviceProject + "WorldMarketTranslationData/" + ConstantMgr._serviceType.ToUpper() + "/" + ConstantMgr._serviceProject + "LocalizedStringWorldTradeMarket_" + str2.ToUpper() + ".txt";
                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);

                        httpWebRequest.Timeout = 60000;
                        end = new StreamReader(httpWebRequest.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd();
                        string str3 = end;
                        char[] chArray2 = new char[1] { '\r' };
                        foreach (string str4 in str3.Split(chArray2))
                        {
                            if (!string.IsNullOrEmpty(str4))
                            {
                                string str5 = str4;
                                if (str4.Contains("\n"))
                                    str5 = str4.Replace("\n", "");
                                if (str5.Split('\t').Length == 3)
                                {
                                    string str6 = str5.Split('\t')[0];
                                    string key = str5.Split('\t')[1];
                                    string str7 = str5.Split('\t')[2];
                                    if (!string.IsNullOrEmpty(str6) && !string.IsNullOrEmpty(key))
                                    {
                                        if (string.IsNullOrEmpty(str7))
                                            str7 = "NoTranslation";
                                        bool flag;
                                        if (str6 == "Category")
                                        {
                                            flag = _categoryStringResource.ContainsKey(str2.ToUpper());
                                            if (flag.Equals(false))
                                                _categoryStringResource.Add(str2.ToUpper(), new Dictionary<string, string>());
                                            _categoryStringResource[str2.ToUpper()].Add(key, str7);
                                        }
                                        else
                                        {
                                            flag = _itemStringResource.ContainsKey(str2.ToUpper());
                                            if (flag.Equals(false))
                                                _itemStringResource.Add(str2.ToUpper(), new Dictionary<string, string>());
                                            _itemStringResource[str2.ToUpper()].Add(key, str7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog("StringManager fail load Info _filePath=" + requestUriString + " // Exception=" + ex.ToString(), "ERROR");
                    return -19;
                }
                _isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.ServerLogWrite(ServerLogType.eComplete, nameof(StringManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public Dictionary<string, string> CategoryStringList
        {
            get
            {
                string str = CommonModule.GetCultureCode(ConstantMgr.GetDefaultLanguage).ToLower();
                if (ConstantMgr._languageList.Contains(str).Equals(false))
                    str = ConstantMgr._defaultLanguage;
                return _categoryStringResource[str.ToUpper()];
            }
        }

        public Dictionary<string, string> ItemStringList
        {
            get
            {
                string str = CommonModule.GetCultureCode(ConstantMgr.GetDefaultLanguage).ToLower();
                if (ConstantMgr._languageList.Contains(str).Equals(false))
                    str = ConstantMgr._defaultLanguage;
                return _itemStringResource[str.ToUpper()];
            }
        }

        public string ItemName(int mainKey)
        {
            string str = "-";
            try
            {
                if (ItemStringList.ContainsKey(mainKey.ToString()))
                    str = ItemStringList[mainKey.ToString()];
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("StringManager key={0} fail load xml - {1}", mainKey, ex.ToString()), "ERROR");
            }
            return str;
        }
    }
}
