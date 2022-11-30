// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Lib.Manager.UpdateTickCount
// Assembly: GB.BlackDesert.Trade.Web.Lib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2C0DA5E-915E-4539-97D5-41BCE7B5ABE2
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Lib.dll

using GB.BlackDesert.Trade.Web.Lib.Common;
using GB.BlackDesert.Trade.Web.Lib.Util;
using System;

namespace GB.BlackDesert.Trade.Web.Lib.Manager
{
    public class UpdateTickCount
    {
        private static object _locker = new object();
        private static bool _flag = false;

        public static void Excute(object state)
        {
            lock (UpdateTickCount._locker)
            {
                if (UpdateTickCount._flag)
                    return;
                UpdateTickCount._flag = true;
            }
            try
            {
                UpdateTickCount.updateTickCount();
                ServerLogManager.serverLogWrite(ServerLogType.eRunTimer, string.Format("[{0}]UpdateTickCount", state));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(string.Format("[{0}]UpdateTickCount Exception={1}", state, (object)ex.ToString()), "ERROR");
            }
            lock (UpdateTickCount._locker)
                UpdateTickCount._flag = false;
        }

        private static void updateTickCount()
        {
            if (!ServerControlManager.This().IsLoadComplete())
                LogUtil.WriteLog(string.Format("updateTickCount Fail is Not Open"), "WARN");
            else if (WorldMarketOptionManager.This().isSleepTime())
                LogUtil.WriteLog(string.Format("[Update INFO]updateTickCount() isSleepTime {0}", (object)DateTime.Now.Hour), "INFO");
            else
                TickCountManager.This().updateTickCountXXX();
        }
    }
}
