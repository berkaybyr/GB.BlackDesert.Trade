namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPs4cashInfoLog
	{
		public long LogNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public string EntitlementId { get; set; } = null!;
		public long CreatedCount { get; set; }
		public int CashProductNo { get; set; }
		public long MailNo { get; set; }
	}
}
