namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildRankingInfo
	{
		public long GuildNo { get; set; }
		public string GuildName { get; set; } = null!;
		public long MasterUserNo { get; set; }
		public string? MasterUserNickname { get; set; }
		public int? SiegeCount { get; set; }
		public int? RegionKey1 { get; set; }
		public int? RegionKey2 { get; set; }
		public int? RegionKey3 { get; set; }
		public int? SpotSiegeCount { get; set; }
		public int? WinCount { get; set; }
		public int AquiredSkillPoint { get; set; }
		public int? MemberCount { get; set; }
		public int VariedMemberCount { get; set; }
		public byte GuildGrade { get; set; }
		public bool? IsIntroduction { get; set; }
		public int? CommentCount { get; set; }
		public DateTime? CommentRegdate { get; set; }
		public int? GuildBattleRating { get; set; }
		public DateTime? IntroductionUpdateDate { get; set; }
	}
}
