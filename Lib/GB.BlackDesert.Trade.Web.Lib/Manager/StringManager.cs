// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.StringManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
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
            this._isOpen = false;
            StringManager._categoryStringResource = new Dictionary<string, Dictionary<string, string>>();
            StringManager._itemStringResource = new Dictionary<string, Dictionary<string, string>>();
        }

        public static StringManager This()
        {
            if (StringManager._singleton == null)
            {
                lock (StringManager._locker)
                {
                    if (StringManager._singleton == null)
                        StringManager._singleton = new StringManager();
                }
            }
            return StringManager._singleton;
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
            lock (StringManager._locker)
            {
                if (this._isOpen)
                {
                    ServerLogManager.serverLogWrite(ServerLogType.eAlready, nameof(StringManager));
                    return 0;
                }
                ServerLogManager.serverLogWrite(ServerLogType.eStart, nameof(StringManager));
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
                        if (ConstantMgr._isUseS3)
                        {
                            end = AmazonS3.Current.AmazonS3ObjectToString("/" + ConstantMgr.GetDefaultLanguage.ToUpper() + "/TradeMarket/Common/xml/" + ConstantMgr._serviceProject + "WorldMarketTranslationData/" + ConstantMgr._serviceType.ToUpper(), ConstantMgr._serviceProject + "LocalizedStringWorldTradeMarket_" + str2.ToUpper() + ".txt");
                        }
                        else
                        {
                            requestUriString = ConstantMgr._tradeXMLDomain + "/Common/xml/" + ConstantMgr._serviceProject + "WorldMarketTranslationData/" + ConstantMgr._serviceType.ToUpper() + "/" + ConstantMgr._serviceProject + "LocalizedStringWorldTradeMarket_" + str2.ToUpper() + ".txt";
                            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
                            if (ConstantMgr._isUseProxy)
                                httpWebRequest.Proxy = (IWebProxy)new WebProxy(string.Format("{0}:{1}", (object)ConstantMgr._webProxyUrl, (object)ConstantMgr._webProxyPort))
                                {
                                    BypassProxyOnLocal = false
                                };
                            httpWebRequest.Timeout = 60000;
                            end = new StreamReader(httpWebRequest.GetResponse().GetResponseStream(), Encoding.UTF8).ReadToEnd();
                        }
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
                                            flag = StringManager._categoryStringResource.ContainsKey(str2.ToUpper());
                                            if (flag.Equals(false))
                                                StringManager._categoryStringResource.Add(str2.ToUpper(), new Dictionary<string, string>());
                                            StringManager._categoryStringResource[str2.ToUpper()].Add(key, str7);
                                        }
                                        else
                                        {
                                            flag = StringManager._itemStringResource.ContainsKey(str2.ToUpper());
                                            if (flag.Equals(false))
                                                StringManager._itemStringResource.Add(str2.ToUpper(), new Dictionary<string, string>());
                                            StringManager._itemStringResource[str2.ToUpper()].Add(key, str7);
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
                this._isOpen = true;
            }
            stopwatch.Stop();
            ServerLogManager.serverLogWrite(ServerLogType.eComplete, nameof(StringManager), stopwatch.ElapsedMilliseconds.ToString());
            return 0;
        }

        public Dictionary<string, string> CategoryStringList
        {
            get
            {
                string str = CommonModule.GetCultureCode(ConstantMgr.GetDefaultLanguage).ToLower();
                if (ConstantMgr._languageList.Contains(str).Equals(false))
                    str = ConstantMgr._defaultLanguage;
                return StringManager._categoryStringResource[str.ToUpper()];
            }
        }

        public Dictionary<string, string> ItemStringList
        {
            get
            {
                string str = CommonModule.GetCultureCode(ConstantMgr.GetDefaultLanguage).ToLower();
                if (ConstantMgr._languageList.Contains(str).Equals(false))
                    str = ConstantMgr._defaultLanguage;
                return StringManager._itemStringResource[str.ToUpper()];
            }
        }

        public string ItemName(int mainKey)
        {
            string str = "-";
            try
            {
                if (this.ItemStringList.ContainsKey(mainKey.ToString()))
                    str = this.ItemStringList[mainKey.ToString()];
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("StringManager key={0} fail load xml - {1}", (object)mainKey, (object)ex.ToString()), "ERROR");
            }
            return str;
        }
    }
}
