namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPendingRewardLog
	{
		public long LogNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public int? ItemKey { get; set; }
		public long? ItemCount { get; set; }
		public byte? Type { get; set; }
	}
}
