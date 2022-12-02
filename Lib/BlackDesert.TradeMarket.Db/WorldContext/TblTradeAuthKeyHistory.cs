namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblTradeAuthKeyHistory
	{
		public long HistoryNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public byte? Type { get; set; }
		public long? UserNo { get; set; }
		public string? RequestKey { get; set; }
		public string? CurKey { get; set; }
		public DateTime? CurUpdateDate { get; set; }
		public string? PrevKey { get; set; }
		public DateTime? PrevUpdateDate { get; set; }
		public long? ReturnValue { get; set; }
	}
}
