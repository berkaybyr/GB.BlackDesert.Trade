namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceContentReward
	{
		public long RewardNo { get; set; }
		public DateTime UpdateDate { get; set; }
		public long UserNo { get; set; }
		public long? ItemKey { get; set; }
		public long? ItemCount { get; set; }
		public byte? Type { get; set; }
	}
}
