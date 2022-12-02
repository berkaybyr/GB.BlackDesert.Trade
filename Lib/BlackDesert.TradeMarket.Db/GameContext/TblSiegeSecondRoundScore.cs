namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSiegeSecondRoundScore
	{
		public int SiegeScoreNo { get; set; }
		public DateTime? UpdateDate { get; set; }
		public long GuildNo { get; set; }
		public string GuildName { get; set; } = null!;
		public string? MasterNickname { get; set; }
		public int TerritoryKey { get; set; }
		public int RegionKey { get; set; }
		public int HpScore { get; set; }
		public int BuildScore { get; set; }
		public int KillScore { get; set; }
		public int DeathScore { get; set; }
		public long DestroyTime { get; set; }
	}
}
