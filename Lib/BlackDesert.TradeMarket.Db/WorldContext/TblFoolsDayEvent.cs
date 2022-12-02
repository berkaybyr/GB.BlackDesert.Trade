namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblFoolsDayEvent
	{
		public DateTime? RegisterDate { get; set; }
		public DateTime? MDate { get; set; }
		public long? ItemKey { get; set; }
		public long? SumCount { get; set; }
	}
}
