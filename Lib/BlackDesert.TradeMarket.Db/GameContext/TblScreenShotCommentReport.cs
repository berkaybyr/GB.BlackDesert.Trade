namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblScreenShotCommentReport
	{
		public long ScreenCommentNo { get; set; }
		public long UserNo { get; set; }
		public bool IsBlind { get; set; }
		public string BlindType { get; set; } = null!;
		public DateTime ReportDate { get; set; }
	}
}
