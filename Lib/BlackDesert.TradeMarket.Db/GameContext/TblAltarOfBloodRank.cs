namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblAltarOfBloodRank
	{
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public string UserCharacterName { get; set; } = null!;
		public short ContentsType { get; set; }
		public int Stage { get; set; }
		public int Score { get; set; }
		public DateTime RegisterDate { get; set; }
		public long RankingRowNum { get; set; }
		public string GuildName { get; set; } = null!;
	}
}
