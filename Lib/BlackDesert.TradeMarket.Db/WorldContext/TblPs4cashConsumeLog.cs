namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4cashConsumeLog
	{
		public long LogNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public long UseLimit { get; set; }
		public long UseCount { get; set; }
		public string EntitlementId { get; set; } = null!;
		public int CashProductNo { get; set; }
		public long MailNo { get; set; }
	}
}
