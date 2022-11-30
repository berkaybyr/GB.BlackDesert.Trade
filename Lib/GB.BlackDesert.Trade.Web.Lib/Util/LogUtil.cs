// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.LogUtil
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.DB;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Layout.Pattern;
using log4net.Repository;
using log4net.Util;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace GB.BlackDesert.Trade.Web.Lib.Util
{
    public static class LogUtil
    {
        public static string[] permitHeadersArr = new string[20]
        {
      "HOST",
      "ORIGIN",
      "X-FORWARDED-FOR",
      "ACCEPT",
      "ACCESSTOKEN",
      "CONTENT-LENGTH",
      "CONTENT-TYPE",
      "COOKIE",
      "REFERER",
      "SEC-CH-UA",
      "SEC-CH-UA-MOBILE",
      "SEC-FETCH-SITE",
      "SERVERREGION",
      "USER-AGENT",
      "X-ORIGINAL-HOST",
      "X-ORIGINAL-URL",
      "X-ORIGINAL-IP",
      "X-FORWARDED-PORT",
      "X-FORWARDED-PROTO",
      "X-PA-IP"
        };

        private static LogEnableModel EnableWebLogFlag => new CacheService().Get<LogEnableModel>("EnableLogFlag", 1200, (Func<LogEnableModel>)(() =>
        {
            LogEnableModel enableWebLogFlag = (LogEnableModel)null;
            uspGetLogWriteEnable_Result writeEnableResult = (uspGetLogWriteEnable_Result)null;
            try
            {
                using (TradeWebDB tradeWebDb = new TradeWebDB())
                    writeEnableResult = ((IEnumerable<uspGetLogWriteEnable_Result>)tradeWebDb.uspGetLogWriteEnable()).FirstOrDefault<uspGetLogWriteEnable_Result>();
                if (writeEnableResult != null)
                    enableWebLogFlag = new LogEnableModel()
                    {
                        Debug = writeEnableResult.C_writeDebugLog,
                        Info = writeEnableResult.C_writeInfoLog,
                        Warring = writeEnableResult.C_writeWarringLog,
                        Error = writeEnableResult.C_writeErrorLog,
                        Fatal = writeEnableResult.C_writeFatalLog
                    };
            }
            catch
            {
                enableWebLogFlag = new LogEnableModel();
            }
            finally
            {
                if (enableWebLogFlag == null)
                    enableWebLogFlag = new LogEnableModel();
            }
            return enableWebLogFlag;
        }));

        public static void WriteLog(
          string Message,
          string Level,
          LogDetailFlag logDetailFlag = LogDetailFlag.none,
          AuthenticationInfo user = null)
        {
            ILoggerRepository repository = LogManager.GetRepository();
            log4net.Repository.Hierarchy.Hierarchy hierarchy = (log4net.Repository.Hierarchy.Hierarchy)repository;
            string name = new DirectoryInfo(HostingEnvironment.ApplicationPhysicalPath).Name;
            string str1 = Path.GetPathRoot(HostingEnvironment.MapPath("~")) + "palog\\" + ConstantMgr._platform.ToLower() + "\\web\\" + ConstantMgr._serviceType.ToUpper();
            string str2 = "json";
            repository.Configured = true;
            string str3;
            if (ConstantMgr._branches.Equals("live", StringComparison.OrdinalIgnoreCase).Equals(true))
                str3 = str1 + "_" + name;
            else
                str3 = str1 + "_" + ConstantMgr._branches.ToUpper() + "_" + name;
            if (ConstantMgr._branches.Equals("local") || ConstantMgr._branches.Equals("cert") || ConstantMgr._serviceType.ToUpper().Equals("SA"))
                str2 = "text";
            if (0 < ((IEnumerable<IAppender>)((IEnumerable<IAppender>)repository.GetAppenders()).ToList<IAppender>()).Where<IAppender>((Func<IAppender, bool>)(x => x.Name == "COMMONLOGGER")).Count<IAppender>())
                repository.ResetConfiguration();
            object obj;
            ILog logger;
            if (str2.Equals("text"))
            {
                if (((IEnumerable<IAppender>)((IEnumerable<IAppender>)repository.GetAppenders()).ToList<IAppender>()).Where<IAppender>((Func<IAppender, bool>)(x => x.Name == "TextLogger")).Count<IAppender>() <= 0)
                {
                    PatternLayout patternLayout = new PatternLayout()
                    {
                        ConversionPattern = "%date [%thread] %-5level %logger - %message%newline"
                    };
                    ((LayoutSkeleton)patternLayout).ActivateOptions();
                    RollingFileAppender rollingFileAppender1 = new RollingFileAppender();
                    ((AppenderSkeleton)rollingFileAppender1).Name = "TextLogger";
                    rollingFileAppender1.StaticLogFileName = true;
                    ((FileAppender)rollingFileAppender1).File = str3 + ".log";
                    ((FileAppender)rollingFileAppender1).AppendToFile = true;
                    rollingFileAppender1.RollingStyle = (RollingFileAppender.RollingMode)2;
                    rollingFileAppender1.DatePattern = "_yyyyMMdd\".log\"";
                    ((AppenderSkeleton)rollingFileAppender1).Layout = (ILayout)patternLayout;
                    RollingFileAppender rollingFileAppender2 = rollingFileAppender1;
                    hierarchy.Root.AddAppender((IAppender)rollingFileAppender2);
                    hierarchy.Root.Level = log4net.Core.Level.All;
                    ((AppenderSkeleton)rollingFileAppender2).ActivateOptions();
                }
                obj = (object)Message;
                logger = LogManager.GetLogger("TextLogger");
            }
            else
            {
                LogMessageModel logMessageModel = new LogMessageModel();
                if (((IEnumerable<IAppender>)((IEnumerable<IAppender>)repository.GetAppenders()).ToList<IAppender>()).Where<IAppender>((Func<IAppender, bool>)(x => x.Name == "JsonLogger")).Count<IAppender>() <= 0)
                {
                    SerializedLayout serializedLayout = new SerializedLayout()
                    {
                        SerializingConverter = (PatternConverter)new JsonPatternConverter()
                    };
                    serializedLayout.AddDefault("nxlog");
                    serializedLayout.AddRemove("message");
                    serializedLayout.AddMember("Message:messageobject");
                    serializedLayout.AddMember("Properties");
                    serializedLayout.AddMember("FullInfo");
                    serializedLayout.AddMember("LocationInfo:FullInfo");
                    ((LayoutSkeleton)serializedLayout).ActivateOptions();
                    RollingFileAppender rollingFileAppender3 = new RollingFileAppender();
                    ((AppenderSkeleton)rollingFileAppender3).Name = "JsonLogger";
                    rollingFileAppender3.StaticLogFileName = true;
                    ((FileAppender)rollingFileAppender3).File = str3 + ".json";
                    ((FileAppender)rollingFileAppender3).AppendToFile = true;
                    rollingFileAppender3.RollingStyle = (RollingFileAppender.RollingMode)2;
                    rollingFileAppender3.DatePattern = "_yyyyMMdd\".json\"";
                    ((AppenderSkeleton)rollingFileAppender3).Layout = (ILayout)serializedLayout;
                    RollingFileAppender rollingFileAppender4 = rollingFileAppender3;
                    hierarchy.Root.AddAppender((IAppender)rollingFileAppender4);
                    hierarchy.Root.Level = log4net.Core.Level.All;
                    ((AppenderSkeleton)rollingFileAppender4).ActivateOptions();
                }
                try
                {
                    logMessageModel.LogMessage = (object)Message;
                    logMessageModel.ProjectName = name;
                    logMessageModel.Branches = ConstantMgr._branches.ToUpper();
                    logMessageModel.ServiceType = ConstantMgr._serviceType.ToUpper();
                    logMessageModel.AuthInfo = user;
                    logMessageModel.PlatformIndex = ConstantMgr._branches.Equals("live", StringComparison.OrdinalIgnoreCase) ? "live-web-" + ConstantMgr._platform.ToLower() : "dev-web-" + ConstantMgr._platform.ToLower();
                    if (HttpContext.Current.Request != null)
                        logMessageModel.Ip = CommonModule.GetRemoteIP();
                    if (HttpContext.Current?.Request != null)
                    {
                        logMessageModel.HttpMethod = HttpContext.Current.Request.HttpMethod ?? "";
                        logMessageModel.RequestUrl = string.Format("{0}", (object)HttpContext.Current.Request.Url);
                        logMessageModel.Headers = LogUtil.AppendNameValueCollectionString(HttpContext.Current.Request.Headers);
                    }
                }
                catch (Exception ex)
                {
                    logMessageModel.LogException = ex.ToString();
                }
                obj = (object)logMessageModel;
                logger = LogManager.GetLogger("JsonLogger");
            }
            if (logger.IsDebugEnabled && Level.Equals("DEBUG"))
            {
                if (!ConstantMgr._isLive.Equals(false))
                    return;
                logger.Debug(obj);
            }
            else if (logger.IsInfoEnabled && Level.Equals("INFO"))
                logger.Info(obj);
            else if (logger.IsWarnEnabled && Level.Equals("WARN"))
                logger.Warn(obj);
            else if (logger.IsErrorEnabled && Level.Equals("ERROR"))
            {
                logger.Error(obj);
            }
            else
            {
                if (!logger.IsFatalEnabled || !Level.Equals("FATAL"))
                    return;
                logger.Fatal(obj);
            }
        }

        private static Dictionary<string, string> AppendNameValueCollectionString(
          NameValueCollection nv)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>(nv.AllKeys.Length);
            foreach (string allKey in nv.AllKeys)
            {
                if (((IEnumerable<string>)LogUtil.permitHeadersArr).Contains<string>(allKey.ToUpper()) && allKey.ToLower().Contains("incap").Equals(false))
                    dictionary.Add(allKey, string.Join("&", nv.GetValues(allKey)));
            }
            return dictionary;
        }
    }
}
