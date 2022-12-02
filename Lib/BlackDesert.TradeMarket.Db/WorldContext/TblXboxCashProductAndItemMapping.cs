namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblXboxCashProductAndItemMapping
	{
		public DateTime RegisterDate { get; set; }
		public string LegacyProductId { get; set; } = null!;
		public string ProductId { get; set; } = null!;
		public int CashProductNo { get; set; }
		public byte NationType { get; set; }
		public string? Description { get; set; }
		public bool IsBundleProduct { get; set; }
		public bool IsSingularItem { get; set; }
	}
}
