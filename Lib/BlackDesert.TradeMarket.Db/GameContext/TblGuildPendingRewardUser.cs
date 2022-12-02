namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildPendingRewardUser
	{
		public long RewardNo { get; set; }
		public long GuildNo { get; set; }
		public long UserNo { get; set; }
		public bool IsRecieve { get; set; }
	}
}
