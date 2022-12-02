namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblHorseRacingPreTotalRank
	{
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public string ServantName { get; set; } = null!;
		public int Season { get; set; }
		public int Rank { get; set; }
		public byte MapKey { get; set; }
		public int PlayCount { get; set; }
		public int FirstCount { get; set; }
		public int SecondCount { get; set; }
		public int ThirdCount { get; set; }
		public int TotalScore { get; set; }
	}
}
