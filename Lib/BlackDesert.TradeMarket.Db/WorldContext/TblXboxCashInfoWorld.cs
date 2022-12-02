namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblXboxCashInfoWorld
	{
		public DateTime RegisterDate { get; set; }
		public string AccountNo { get; set; } = null!;
		public string LegacyProductId { get; set; } = null!;
		public long ProductCount { get; set; }
		public long ConsumeCount { get; set; }
		public string PurchaseCountry { get; set; } = null!;
	}
}
