namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMarbleGameDiceItem
	{
		public long UserNo { get; set; }
		public int DiceItemKey { get; set; }
		public int Count { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
