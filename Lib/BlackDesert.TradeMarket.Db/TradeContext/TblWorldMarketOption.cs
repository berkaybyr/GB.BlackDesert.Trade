namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketOption
	{
		public bool? IsMarketOpen { get; set; }
		public int RingBuff { get; set; }
		public bool? IsRingBuff { get; set; }
		public long WaitPrice { get; set; }
	}
}
