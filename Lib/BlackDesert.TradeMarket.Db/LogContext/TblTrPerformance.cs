namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblTrPerformance
	{
		public DateTime RegisterDate { get; set; }
		public long ServerNo { get; set; }
		public int TrId { get; set; }
		public string? TrName { get; set; }
		public int CallCount { get; set; }
		public long TotalElapsedTime { get; set; }
		public long SlowElapsedTime { get; set; }
		public long LastStartTime { get; set; }
	}
}
