// Decompiled with JetBrains decompiler
// Type: GB.BlackDesert.Trade.Web.Game.Models.GameTradeMarketUserInfo
// Assembly: GB.BlackDesert.Trade.Web.Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4566C30B-F0F5-4951-81D2-B4EE3D7A09A1
// Assembly location: C:\Users\kkass\OneDrive\Masaüstü\MarketDLL\GB.BlackDesert.Trade.Web.Game.dll

using GB.BlackDesert.Trade.Web.Lib.Sql;

namespace GB.BlackDesert.Trade.Web.Game.Api.Models
{
    public class GameTradeMarketUserInfo
    {
        public string userNickName { set; get; }

        public int nationCode { set; get; }

        public int worldNo { set; get; }

        public long userNo { set; get; }

        public DateTime packageExpiration { set; get; }

        public DateTime addWeightBuffExpiration { set; get; }

        public int familyPoint { set; get; }

        public int maidCount { set; get; }

        public bool isGameMaster { set; get; }

        public List<uspFamilySKillListFromWorldMarket_Result> familySkillList { set; get; }

        public int ringMaxCount { set; get; }

        public string userId { set; get; }

        public GameTradeMarketUserInfo()
        {
            this.nationCode = 0;
            this.worldNo = 0;
            this.userNo = 0L;
            this.userNickName = string.Empty;
            this.packageExpiration = DateTime.MinValue;
            this.addWeightBuffExpiration = DateTime.MinValue;
            this.familyPoint = 0;
            this.maidCount = 0;
            this.isGameMaster = false;
            this.userId = string.Empty;
            this.familySkillList = new List<uspFamilySKillListFromWorldMarket_Result>();
            this.ringMaxCount = 0;
        }
    }
}
