namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMarbleGame
	{
		public long UserNo { get; set; }
		public byte PlayMarbleKey { get; set; }
		public int TodayPlayDiceCount { get; set; }
		public DateTime RegisterDate { get; set; }
		public int TodayFreeDiceCount { get; set; }
		public DateTime? NextFreeDiceDate { get; set; }
		public DateTime? DailyResetDate { get; set; }
		public DateTime? NextPlayCardDate { get; set; }
		public byte PrePlayMarbleKey { get; set; }
		public int CompleteCount { get; set; }
		public int RewardCompleteCount { get; set; }
	}
}
