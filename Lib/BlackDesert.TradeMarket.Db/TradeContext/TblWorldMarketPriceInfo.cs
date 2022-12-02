namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketPriceInfo
	{
		public long RegistTimeStamp { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public long Price { get; set; }
	}
}
