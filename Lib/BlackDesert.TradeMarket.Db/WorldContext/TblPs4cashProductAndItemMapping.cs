namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4cashProductAndItemMapping
	{
		public DateTime RegisterDate { get; set; }
		public string EntitlementId { get; set; } = null!;
		public int CashProductNo { get; set; }
		public byte NationType { get; set; }
		public string? Description { get; set; }
		public bool IsBundleProduct { get; set; }
	}
}
