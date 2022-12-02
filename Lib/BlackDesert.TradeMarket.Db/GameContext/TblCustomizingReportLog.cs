namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCustomizingReportLog
	{
		public long CustomizingCommentNo { get; set; }
		public long UserNo { get; set; }
		public bool IsBlind { get; set; }
		public byte BlindType { get; set; }
		public DateTime ReportDate { get; set; }
	}
}
