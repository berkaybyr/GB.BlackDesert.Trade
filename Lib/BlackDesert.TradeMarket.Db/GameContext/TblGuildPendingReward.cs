namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildPendingReward
	{
		public long RewardNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime ExpireDate { get; set; }
		public long GuildNo { get; set; }
		public string ItemString { get; set; } = null!;
	}
}
