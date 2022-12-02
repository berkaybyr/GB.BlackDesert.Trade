namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBattleRoyaleUserPlayTimeLog
	{
		public int? MDate { get; set; }
		public long? UserNo { get; set; }
		public long? TotalPlayTimePerDay { get; set; }
		public long? GamePlayTimePerDay { get; set; }
	}
}
