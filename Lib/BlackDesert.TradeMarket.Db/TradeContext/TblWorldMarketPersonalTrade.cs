namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketPersonalTrade
	{
		public long MarketNo { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public long Count { get; set; }
		public long PricePerOne { get; set; }
		public int FromNationCode { get; set; }
		public int FromServerNo { get; set; }
		public long FromUserNo { get; set; }
		public int ToNationCode { get; set; }
		public int ToServerNo { get; set; }
		public long ToUserNo { get; set; }
	}
}
