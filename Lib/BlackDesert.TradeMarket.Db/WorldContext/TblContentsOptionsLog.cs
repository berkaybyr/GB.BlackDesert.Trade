namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblContentsOptionsLog
	{
		public DateTime ProcessTime { get; set; }
		public long ContentsOptionKey { get; set; }
		public int ChangingStatus { get; set; }
	}
}
