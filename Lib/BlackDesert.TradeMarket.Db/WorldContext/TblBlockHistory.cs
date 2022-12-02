namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblBlockHistory
	{
		public long HistoryNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public DateTime EndDate { get; set; }
		public int BlockCode { get; set; }
		public string OperationMemo { get; set; } = null!;
	}
}
