namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSimpleGuildInviteList
	{
		public DateTime RegisterDate { get; set; }
		public long HostUserNo { get; set; }
		public long HostGuildNo { get; set; }
		public long ReciveUserNo { get; set; }
		public string GuildName { get; set; } = null!;
		public string HostUserNickName { get; set; } = null!;
	}
}
