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
        public static void serverLogWrite(ServerLogType logType, string name = "", string processTime = "")
        {
            string empty = string.Empty;
            string str;
            switch (logType)
            {
                case ServerLogType.eStart:
                    str = "Open Start 서비스를 시작 합니다!";
                    break;
                case ServerLogType.eComplete:
                    str = "Open Complete 서비스 오픈을 완료했습니다!";
                    break;
                case ServerLogType.eAlready:
                    str = "already Open 이미 서비스가 정상 오픈 되어 있습니다.";
                    break;
                case ServerLogType.eImpossible:
                    str = "Impossible Open 서비스 오픈이 불가능합니다.";
                    break;
                case ServerLogType.eLoading:
                    str = "Loading... 로딩 중에는 로딩할 수 없습니다. 완료 후 가능합니다.";
                    break;
                case ServerLogType.eNotOpen:
                    str = "Not Open... 매니저가 오픈되지 않았습니다. 오픈 된 후 초기화가 가능합니다.";
                    break;
                case ServerLogType.eRunTimer:
                    str = "Run Timer 타이머가 정상 처리되었습니다.";
                    break;
                case ServerLogType.eSetTimer:
                    str = "Set Timer 타이머 등록 완료!";
                    break;
                case ServerLogType.eOpen:
                    str = "All Open! 모든 서비스가 오픈 되었습니다. 서비스를 시작합니다!";
                    break;
                default:
                    str = "Nothing";
                    break;
            }
            if (!processTime.Equals("") && logType == ServerLogType.eComplete)
                processTime = "\n\t\t\t\t\t\t-----처리 완료 시간 [Processing ms = (" + processTime + ")]------\n";
            LogUtil.WriteLog("[" + name + "] " + str + " " + processTime, "INFO");
        }

        public static void serverErrorLogWrite(string name = "", int errorCode = 0, string errorSource = "") => LogUtil.WriteLog("[" + name + "] " + errorSource + " Slack_Alarm error!! 처리중 오류가 발생했습니다!!" + string.Format("\n\t\t\t\t\t\trv = ({0})", errorCode), "ERROR");
    }
}
