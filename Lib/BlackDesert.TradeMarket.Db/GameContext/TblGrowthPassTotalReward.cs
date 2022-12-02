namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGrowthPassTotalReward
	{
		public long UserNo { get; set; }
		public int TotalRewardKey { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
