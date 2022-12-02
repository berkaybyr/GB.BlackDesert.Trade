namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSyncGuildInformation
	{
		public DateTime MemberRegisterDate { get; set; }
		public DateTime GuildRegisterDate { get; set; }
		public long UserNo { get; set; }
		public long MasterUserNo { get; set; }
		public long GuildNo { get; set; }
		public string GuildName { get; set; } = null!;
		public byte GuildGrade { get; set; }
		public int? RegionKey { get; set; }
	}
}
