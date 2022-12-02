namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGrowthPassCategoryReward
	{
		public long UserNo { get; set; }
		public int CategoryKey { get; set; }
		public int RewardIndex { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
