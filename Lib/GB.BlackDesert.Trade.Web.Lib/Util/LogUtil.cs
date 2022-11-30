// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Util.LogUtil
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using EasMe;
using EasMe.Extensions;
using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Sql;
using GB.BlackDesert.Trade.Web.Lib.Manager;
using GB.BlackDesert.Trade.Web.Lib.Models;
using log4net;
using log4net.Appender;
using log4net.Layout;
using log4net.Layout.Pattern;
using log4net.Repository;
using log4net.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;

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

        public static void ConfigureLoggerConfigBasic()
        {
            IEasLog.LoadConfig(new EasLogConfiguration
            {
                WebInfoLogging = true,
                AddRequestUrlToStart = true,
                ConsoleAppender = true,
                ExceptionHideSensitiveInfo = false,
                LogFileName = "CentralMarket_",
                TraceLogging = false,
                IsDebug = false,
                IsLogJson = true,
                SeperateLogLevelToFolder = false,
                StackLogCount = 0,
                LogFileExtension = ".json",
            });
        }
        public static void ConfigureLoggerConfig(string name)
        {
            IEasLog.LoadConfig(new EasLogConfiguration
            {
                WebInfoLogging = true,
                AddRequestUrlToStart = true,
                ConsoleAppender = true,
                ExceptionHideSensitiveInfo = false,
                LogFileName = name + "_",
                TraceLogging = false,
                IsDebug = false,
                IsLogJson = true,
                SeperateLogLevelToFolder = false,
                StackLogCount = 0,
                LogFileExtension = ".json",
            });
        }
        public static void ConfigureLoggerConfigDebug(string name)
        {
            IEasLog.LoadConfig(new EasLogConfiguration
            {
                WebInfoLogging = true,
                AddRequestUrlToStart = true,
                ConsoleAppender = true,
                ExceptionHideSensitiveInfo = false,
                LogFileName = name + "_",
                TraceLogging = true,
                IsDebug = true,
                IsLogJson = true,
                SeperateLogLevelToFolder = false,
                StackLogCount = 0,
                LogFileExtension = ".json",
            });
        }
        public static void ConfigureLoggerConfigRelease(string name)
        {
            IEasLog.LoadConfig(new EasLogConfiguration
            {
                WebInfoLogging = true,
                AddRequestUrlToStart = true,
                ConsoleAppender = false,
                ExceptionHideSensitiveInfo = false,
                LogFileName = name + "_",
                TraceLogging = false,
                IsDebug = false,
                IsLogJson = true,
                SeperateLogLevelToFolder = true,
                StackLogCount = 5,
                LogFileExtension = ".json",
            });
        }
        private static readonly EasLog logger = IEasLog.CreateLogger("TradeMarket");
        public static void WriteLog(
        string Message,
          string Level,
          LogDetailFlag logDetailFlag = LogDetailFlag.none,
          AuthenticationInfo user = null)
        {
            switch (Level)
            {
                case "INFO":
                    logger.Info(Message + " - " + user.JsonSerialize() ?? "");
                    break;
                case "WARN":
                    logger.Warn(Message + " - " + user.JsonSerialize() ?? "");
                    break;
                case "ERROR":
                    logger.Error(Message + " - " + user.JsonSerialize() ?? "");
                    break;
                case "FATAL":
                    logger.Fatal(Message + " - " + user.JsonSerialize() ?? "");
                    break;
                case "DEBUG":
                    logger.Debug(Message + " - " + user.JsonSerialize() ?? "");
                    break;
                case "TRACE":
                    logger.Trace(Message + " - " + user.JsonSerialize() ?? "");
                    break;
                default:
                    logger.Info("LOGTYPE:NONE", logDetailFlag, Message + " - " + user.JsonSerialize());
                    break;
            }
        }



    }
}
