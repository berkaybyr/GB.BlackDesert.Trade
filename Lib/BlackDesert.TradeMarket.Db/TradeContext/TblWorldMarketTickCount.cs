namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketTickCount
	{
		public string ServerIp { get; set; } = null!;
		public int MainGroupNo { get; set; }
		public int CurrentTickCount { get; set; }
		public int UpdateTickCount { get; set; }
		public int AllowIndex { get; set; }
		public DateTime LastUpdateTime { get; set; }
		public long UpdateAccumulateCount { get; set; }
	}
}
