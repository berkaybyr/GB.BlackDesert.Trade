namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblCashProductLogExInmem
	{
		public long? LogNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public int? CashProductNo { get; set; }
		public long? CashItemCount { get; set; }
		public long? Reason { get; set; }
		public long? UserNo { get; set; }
		public long? OriginalPearlCount { get; set; }
		public long? RealUsePearlCount { get; set; }
		public byte? DiscountPercent { get; set; }
		public int? UseCouponKey { get; set; }
		public int? EventCartkey { get; set; }
	}
}
