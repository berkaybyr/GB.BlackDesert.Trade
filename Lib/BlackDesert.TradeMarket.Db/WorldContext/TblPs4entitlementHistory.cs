namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4entitlementHistory
	{
		public long Index { get; set; }
		public DateTime RegDate { get; set; }
		public string UserId { get; set; } = null!;
		public string EntitlementId { get; set; } = null!;
		public long? UseLimit { get; set; }
		public long? UseCount { get; set; }
		public string? PurchaseCountry { get; set; }
	}
}
