namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBattleRoyalePlayTime
	{
		public long UserNo { get; set; }
		public long TotalPlayTime { get; set; }
		public long GamePlayTime { get; set; }
		public long TotalPlayTimePerDay { get; set; }
		public long GamePlayTimePerDay { get; set; }
		public DateTime LastAccumulateTime { get; set; }
		public DateTime LastSoloGameTime { get; set; }
		public DateTime LastTeamGameTime { get; set; }
	}
}
