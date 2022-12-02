namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserGameOptionType
	{
		public long UserNo { get; set; }
		public int GameOptionType { get; set; }
		public string GameOptionValue { get; set; } = null!;
	}
}
