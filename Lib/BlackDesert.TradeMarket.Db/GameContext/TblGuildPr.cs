namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildPr
	{
		public long GuildNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public byte Category { get; set; }
		public bool IsOpen { get; set; }
		public string GuildName { get; set; } = null!;
		public string MasterUserNickName { get; set; } = null!;
		public byte GuildGrade { get; set; }
		public int MemberCount { get; set; }
		public int AquiredSkillPoint { get; set; }
	}
}
