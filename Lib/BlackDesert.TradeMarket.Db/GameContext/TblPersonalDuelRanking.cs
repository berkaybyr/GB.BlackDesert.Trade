namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPersonalDuelRanking
	{
		public long UserNo { get; set; }
		public int Season { get; set; }
		public int WinCount { get; set; }
		public int LoseCount { get; set; }
		public int RankRating { get; set; }
	}
}
