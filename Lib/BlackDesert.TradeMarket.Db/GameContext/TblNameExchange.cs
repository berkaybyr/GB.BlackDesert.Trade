namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblNameExchange
	{
		public long Character1No { get; set; }
		public long Character2No { get; set; }
		public DateTime RegisterDate { get; set; }
		public long OwnerNo { get; set; }
		public string Character2Name { get; set; } = null!;
		public string Character1Name { get; set; } = null!;
	}
}
