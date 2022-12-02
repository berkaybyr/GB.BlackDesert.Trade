namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonCloseChallengeWithReward
	{
		public int ChallengeKey { get; set; }
		public int? ItemKey { get; set; }
		public int? ItemEnchant { get; set; }
		public int? ItemCount { get; set; }
	}
}
