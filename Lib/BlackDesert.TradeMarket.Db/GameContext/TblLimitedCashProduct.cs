namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblLimitedCashProduct
	{
		public DateTime? RegisterDate { get; set; }
		public int CashProductNo { get; set; }
		public int MaxCount { get; set; }
		public int RemainedCount { get; set; }
		public int DiscountPrice { get; set; }
		public DateTime? SalesStartPeriod { get; set; }
		public DateTime? SalesEndPeriod { get; set; }
		public bool IsLimitedCount { get; set; }
	}
}
