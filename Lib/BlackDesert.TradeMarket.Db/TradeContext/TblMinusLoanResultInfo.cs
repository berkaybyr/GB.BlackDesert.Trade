namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblMinusLoanResultInfo
	{
		public long Idx { get; set; }
		public DateTime? RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public long? UserNo { get; set; }
		public string? UserNickname { get; set; }
		public long? MinusMoney { get; set; }
		public long? BeforeMoney { get; set; }
		public long? AfterMoney { get; set; }
	}
}
