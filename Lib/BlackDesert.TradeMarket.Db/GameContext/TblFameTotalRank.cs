namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFameTotalRank
	{
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public long CharacterNo { get; set; }
		public string CharacterName { get; set; } = null!;
		public string? GuildName { get; set; }
		public int Rank { get; set; }
		public int Fame { get; set; }
		public int KillCount { get; set; }
	}
}
