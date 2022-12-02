namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarket
	{
		public int KeyType { get; set; }
		public int MainCategory { get; set; }
		public int SubCategory { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public long PricePerOne { get; set; }
		public long Count { get; set; }
		public long TotalTradeCount { get; set; }
		public bool IsDisplay { get; set; }
		public long PriceGroupKey { get; set; }
		public long MaxTradeCount { get; set; }
		public long MaxPrice { get; set; }
		public long MinPrice { get; set; }
		public long RealMaxPrice { get; set; }
		public long RealMinPrice { get; set; }
		public long SumTradeCount { get; set; }
		public long SumTradePrice { get; set; }
		public long SumTradeCountByStock { get; set; }
		public long AccumulateTickCount { get; set; }
		public long AccumulateBiddingCount { get; set; }
		public byte FluctuationType { get; set; }
		public long FluctuationPrice { get; set; }
		public byte CurrentTrend { get; set; }
		public byte TrendKeepCount { get; set; }
		public DateTime LastTradeTime { get; set; }
		public long LastTradePrice { get; set; }
	}
}
