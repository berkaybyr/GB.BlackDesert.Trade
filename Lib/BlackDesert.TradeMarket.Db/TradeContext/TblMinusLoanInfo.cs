namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblMinusLoanInfo
	{
		public long Idx { get; set; }
		public DateTime? RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public long? MinusMoney { get; set; }
	}
}
