namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCopyUserDate
	{
		public DateTime RegisterDate { get; set; }
		public long LiveUserNo { get; set; }
		public string Nation { get; set; } = null!;
		public string UserId { get; set; } = null!;
	}
}
