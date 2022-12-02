// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.ViewUserAuthModel
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using System.Net;

namespace BlackDesert.TradeMarket.Lib.Models.Game
{
    public class ViewUserAuthModel
    {
        public string userNo { set; get; }

        public string certifiedKey { set; get; }

        public string type { set; get; }

        public long numUserNo 
        { 
            get
            {
                return userNo.ConvertTo<long>();
            }
        }
        public long numType
        {
            get
            {
                return type.ConvertTo<long>();
            }
        }
        public ViewUserAuthModel()
        {
            this.userNo = "0";
            this.certifiedKey = string.Empty;
            this.type = "0";
        }
    }
}
