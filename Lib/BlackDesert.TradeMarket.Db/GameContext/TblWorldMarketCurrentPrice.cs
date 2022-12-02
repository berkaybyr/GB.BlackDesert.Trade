namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblWorldMarketCurrentPrice
	{
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public long PricePerOne { get; set; }
		public DateTime LastUpdateTime { get; set; }
	}
}
