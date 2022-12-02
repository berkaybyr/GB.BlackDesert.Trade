namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemMarketSellByReservation
	{
		public DateTime RegisterDate { get; set; }
		public long ItemMarketNo { get; set; }
		public long ItemNo { get; set; }
		public int ItemEnchantKey { get; set; }
		public long RegisterUserNo { get; set; }
		public long OnePrice { get; set; }
		public long TotalCount { get; set; }
		public long RegisterTerritory { get; set; }
	}
}
