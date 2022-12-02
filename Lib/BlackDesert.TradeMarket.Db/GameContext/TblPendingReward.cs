namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPendingReward
	{
		public long UserNo { get; set; }
		public int ItemKey { get; set; }
		public long? ItemCount { get; set; }
		public byte Type { get; set; }
		public long? RewardNo { get; set; }
		public DateTime UpdateDate { get; set; }
	}
}
