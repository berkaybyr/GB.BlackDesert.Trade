namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserSeasonState
	{
		public long UserNo { get; set; }
		public byte TotalCompleteSeasonCount { get; set; }
		public byte RemainCompleteSeasonCount { get; set; }
		public byte LastCompletedSeasonNo { get; set; }
	}
}
