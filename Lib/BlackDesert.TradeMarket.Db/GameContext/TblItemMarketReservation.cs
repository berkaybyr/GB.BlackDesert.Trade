namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemMarketReservation
	{
		public DateTime RegisterDate { get; set; }
		public int ItemEnchantKey { get; set; }
		public long RegisterUserNo { get; set; }
		public long OnePrice { get; set; }
		public long TotalCount { get; set; }
		public long LeftCount { get; set; }
		public long RegisterTerritory { get; set; }
		public string RegisterCharacterName { get; set; } = null!;
	}
}
