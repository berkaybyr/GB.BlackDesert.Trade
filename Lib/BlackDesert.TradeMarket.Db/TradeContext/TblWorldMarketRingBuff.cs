namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketRingBuff
	{
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public int UsingCount { get; set; }
		public int MaxCount { get; set; }
	}
}
