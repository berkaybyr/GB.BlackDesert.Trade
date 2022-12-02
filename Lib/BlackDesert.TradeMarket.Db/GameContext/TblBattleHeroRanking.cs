namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBattleHeroRanking
	{
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public long Score { get; set; }
		public int JoinCountSeize { get; set; }
		public int WinCountSeize { get; set; }
		public int KillCountSeize { get; set; }
		public int JoinCountBase { get; set; }
		public int WinCountBase { get; set; }
		public int KillCountBase { get; set; }
		public long RankingRowNum { get; set; }
		public long? BeforeRankingRowNum { get; set; }
	}
}
