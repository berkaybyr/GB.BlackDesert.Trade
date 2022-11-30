// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.ConstantMgr
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;


namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public static class ConstantMgr
    {

        public static readonly string _xmlContentsLocalPath = ConfigurationManager.AppSettings["xmlContentsLocalPath"] ?? string.Empty;








        public static readonly string _gameDomain = ConfigurationManager.AppSettings["gameDomain"] ?? string.Empty;
        public static readonly string _processDomain = ConfigurationManager.AppSettings["processDomain"] ?? string.Empty;
        public static readonly string _cdnDomain = ConfigurationManager.AppSettings["cdnDomain"] ?? string.Empty;
        public static readonly string _thisDomain = ConfigurationManager.AppSettings["thisDomain"] ?? string.Empty;
        public static readonly string _tradeXMLDomain = ConfigurationManager.AppSettings["tradeXMLDomain"] ?? string.Empty;
        public static readonly string _tradeRegion = ConfigurationManager.AppSettings["tradeRegion"] ?? string.Empty;
        public static readonly string _tradeDomain = ConfigurationManager.AppSettings["tradeDomain"] ?? string.Empty;

        public static readonly string _defaultCulture = ConfigurationManager.AppSettings["defaultCulture"] ?? string.Empty;
        public static readonly string _cultureList = ConfigurationManager.AppSettings["cultureList"] ?? string.Empty;
        public static readonly string _cultureCookieName = ConfigurationManager.AppSettings["cultureCookieName"] ?? string.Empty;
        public static readonly string _languageList = ConfigurationManager.AppSettings["languageList"] ?? string.Empty;
        public static readonly string _defaultLanguage = ConfigurationManager.AppSettings["defaultLanguage"] ?? string.Empty;




        public static readonly string _serviceProject = "BDO";              //ConfigurationManager.AppSettings["serviceProject"] ?? "BDO"
        public static readonly string _serviceType = ConfigurationManager.AppSettings["serviceType"] ?? "DEV";
        public static readonly string _serviceRegion = ConfigurationManager.AppSettings["serviceRegion"] ?? "NA";
        
        public static readonly int _serviceUtcTime = ConfigurationManager.AppSettings["ServiceUtcTime"].ConvertTo<int>(0);
        public static readonly string _utcTimeZoneID = ConfigurationManager.AppSettings["UtcTimeZoneID"] ?? "Korea Standard Time";

        public static readonly bool _isServerTime = ConfigurationManager.AppSettings["isServerTime"].ConvertTo<bool>(false);

        public static readonly bool _isLive = ConfigurationManager.AppSettings["isLive"].ConvertTo<bool>(false);

        public static readonly string _allowIPList = ConfigurationManager.AppSettings["AllowIPList"] ?? string.Empty;
        public static readonly bool _isTradeWebOpen = false;             //ConfigurationManager.AppSettings["isTradeWebOpen"].ConvertTo<bool>(false);
        public static readonly string _selfServerIP = ConfigurationManager.AppSettings["selfServerIP"] ?? string.Empty;

        public static readonly string _allowBrowserList = ConfigurationManager.AppSettings["AllowBrowserList"] ?? string.Empty;

        public static readonly bool _isCompression = ConfigurationManager.AppSettings["isCompression"].ConvertTo<bool>(false);

        public static readonly string _acceptRefererDomainList = ConfigurationManager.AppSettings["acceptRefererDomain"] ?? string.Empty;
        public static readonly string _publishServiceType = ConfigurationManager.AppSettings["publishServiceType"] ?? string.Empty;


        public static readonly string _paSessionApiUrl = ConfigurationManager.AppSettings["paSessionApiUrl"] ?? string.Empty;
        public static readonly bool _isPaAccount = ConfigurationManager.AppSettings["isPaAccount"].ConvertTo<bool>(false);
        public static readonly string _pearlAppDomain = ConfigurationManager.AppSettings["pearlAppDomain"] ?? string.Empty;
        public static readonly bool _pearlAppActive = ConfigurationManager.AppSettings["pearlAppActive"].ConvertTo<bool>(false);
        public static readonly string _checkPakageUrl = ConfigurationManager.AppSettings["checkPakageUrl"] ?? string.Empty;
        public static readonly string _otpAuthUrl = ConfigurationManager.AppSettings["otpAuthUrl"] ?? string.Empty;
        public static readonly string _oauthCookieName = "PA-STATE";
        public static readonly string _apiBaseOauthUrl = ConfigurationManager.AppSettings["apiBaseOauthUrl"] ?? string.Empty;
        public static readonly int _authenticationTimeOut = ConfigurationManager.AppSettings["authenticationTimeOut"].ConvertTo<int>(5);
        public static readonly bool _useCookieProtect = ConfigurationManager.AppSettings["useCookieProtect"].ConvertTo<bool>(true);
        public static readonly string _serviceAuthCookieName = ConfigurationManager.AppSettings["ServiceAuthCookieName"] ?? string.Empty;
        public static readonly string _authRedirectUri = ConfigurationManager.AppSettings["authRedirectDomain"] ?? string.Empty;
        public static readonly string _authCheckRequestUri = ConfigurationManager.AppSettings["authCheckRequestUri"] ?? string.Empty;
        public static readonly string _authRemoveUri = ConfigurationManager.AppSettings["authRemoveUri"];
        public static readonly string _isUseSecondPwd = ConfigurationManager.AppSettings["isUseSecondPwd"] ?? "NONE";
        public static readonly string _cookieDomain = ConfigurationManager.AppSettings["cookieDomain"] ?? string.Empty;
        public static readonly string _domainPrefix = ConfigurationManager.AppSettings["domainPrefix"] ?? string.Empty;
        public static readonly string _authCookieName = ConfigurationManager.AppSettings["authCookie"] ?? string.Empty;
        public static readonly string _branches = ConfigurationManager.AppSettings["Branches"];
        public static readonly string _platform = ConfigurationManager.AppSettings["PlatForm"] != null ? ConfigurationManager.AppSettings["PlatForm"] : "BDO";

        public static string _accountDomain => ConfigurationManager.AppSettings["accountDomain"] + "/" + CommonModule.GetCulture();

        public static string GetDefaultLanguage => CommonModule.GetCulture() ?? CommonModule.getBrowserCulture();

        //public static string GetDataFilePath() => ConstantMgr._tradeXMLDomain + "/Common/xml";


        public static string[] GetCultureList() => ((IEnumerable<string>)ConstantMgr._cultureList.Split(',')).Distinct<string>().ToArray<string>();

        //public static string GetBIServiceType
        //{
        //    get
        //    {
        //        string empty = string.Empty;
        //        string getBiServiceType;
        //        switch (ConstantMgr._serviceType)
        //        {
        //            case "CS":
        //            case "PS":
        //            case "XB":
        //                getBiServiceType = string.Format("logo_CONSOLE.png?v={0}", (object)DateTime.Now.Hour);
        //                break;
        //            case "JP":
        //            case "KR":
        //            case "SA":
        //            case "TW":
        //                getBiServiceType = string.Format("logo_{0}.png?v={1}", (object)ConstantMgr._serviceType, (object)DateTime.Now.Hour);
        //                break;
        //            default:
        //                getBiServiceType = string.Format("logo.png?v={0}", (object)DateTime.Now.Hour);
        //                break;
        //        }
        //        return getBiServiceType;
        //    }
        //}
    }
}
