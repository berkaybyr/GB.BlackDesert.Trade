namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblEventMarbleGame
	{
		public long UserNo { get; set; }
		public byte PlayMarbleKey { get; set; }
		public byte PrePlayMarbleKey { get; set; }
		public int CompleteCount { get; set; }
		public int RewardCompleteCount { get; set; }
		public int TodayPlayDiceCount { get; set; }
		public DateTime DailyResetDate { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
