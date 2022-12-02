namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMiniGameUserInformation
	{
		public long UserNo { get; set; }
		public int Type { get; set; }
		public int Win { get; set; }
		public int Lose { get; set; }
		public int Draw { get; set; }
		public int Escape { get; set; }
	}
}
