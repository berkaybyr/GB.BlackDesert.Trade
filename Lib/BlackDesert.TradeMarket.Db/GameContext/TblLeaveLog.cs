namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblLeaveLog
	{
		public DateTime? MDate { get; set; }
		public int? Step { get; set; }
		public string? Msg { get; set; }
		public long? Rv { get; set; }
		public long? RowCount { get; set; }
	}
}
