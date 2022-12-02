// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.ServerLogManager
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll


using BlackDesert.TradeMarket.Lib;

namespace BlackDesert.TradeMarket.Application.Manager
{
    public class ServerLogManager
    {
        public static void ServerLogWrite(ServerLogType logType, string name = "", string processTime = "")
        {
            var str = logType switch
            {
                ServerLogType.eStart => "Open Start",
                ServerLogType.eComplete => "Open Complete",
                ServerLogType.eAlready => "Already Open ",
                ServerLogType.eImpossible => "Impossible Open",
                ServerLogType.eLoading => "Loading... ",
                ServerLogType.eNotOpen => "Not Open...",
                ServerLogType.eRunTimer => "Run Timer ",
                ServerLogType.eSetTimer => "Set Timer 타이머 등록 완료!",
                ServerLogType.eOpen => "All Open!",
                _ => "Nothing",
            };
            if (!processTime.Equals("") && logType == ServerLogType.eComplete)
                processTime = "[Processing ms = (" + processTime + ")]------\n";
            LogUtil.Logger.Info(name, $"{str} {processTime}");
        }

        public static void ServerErrorLogWrite(string name = "", int errorCode = 0, string errorSource = "") => LogUtil.Logger.Fatal(name, $"{errorSource} Slack_Alarm error!! rv({errorCode})" );
    }
}
