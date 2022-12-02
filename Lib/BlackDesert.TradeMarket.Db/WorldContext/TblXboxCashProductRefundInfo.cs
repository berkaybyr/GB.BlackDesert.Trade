namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblXboxCashProductRefundInfo
	{
		public long RefundNo { get; set; }
		public string AccountNo { get; set; } = null!;
		public string LegacyProductId { get; set; } = null!;
		public string ProductId { get; set; } = null!;
		public long RefundCount { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime? CompleteDate { get; set; }
		public DateTime? CancelDate { get; set; }
		public byte RefundState { get; set; }
		public long BeforeConsumeCount { get; set; }
		public long AfterConsumeCount { get; set; }
		public long BeforeProductCount { get; set; }
		public long AfterProductCount { get; set; }
		public bool IsCheckProductCount { get; set; }
	}
}
