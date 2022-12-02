namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlackMarble
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public byte NowPosition { get; set; }
		public int FinishCount { get; set; }
		public byte TodayCount { get; set; }
		public DateTime? LastPlayDate { get; set; }
	}
}
