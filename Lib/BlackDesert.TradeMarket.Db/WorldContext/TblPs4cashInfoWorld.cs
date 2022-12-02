namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4cashInfoWorld
	{
		public DateTime RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public string EntitlementId { get; set; } = null!;
		public long UseLimit { get; set; }
		public long UseCount { get; set; }
		public long ConsumeCount { get; set; }
		public DateTime ActiveDate { get; set; }
	}
}
