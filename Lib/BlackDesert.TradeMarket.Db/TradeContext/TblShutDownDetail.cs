namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblShutDownDetail
	{
		public int GroupContentno { get; set; }
		public string CultureCode { get; set; } = null!;
		public string? MainMessage { get; set; }
		public string? SubMessage { get; set; }
		public string? RedirectUrl { get; set; }
		public string? Memo { get; set; }
	}
}
