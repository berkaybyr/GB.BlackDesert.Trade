namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCommonBoardReport
	{
		public byte BoardType { get; set; }
		public long BoardNo { get; set; }
		public long UserNo { get; set; }
		public bool IsBlind { get; set; }
		public byte BlindType { get; set; }
		public DateTime RegDate { get; set; }
		public byte ReportType { get; set; }
	}
}
