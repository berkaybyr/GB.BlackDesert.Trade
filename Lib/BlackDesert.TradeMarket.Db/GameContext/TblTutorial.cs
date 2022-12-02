namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblTutorial
	{
		public long UserNo { get; set; }
		public int Type { get; set; }
		public bool IsComplete { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
