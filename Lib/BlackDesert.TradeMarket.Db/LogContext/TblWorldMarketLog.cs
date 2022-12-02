namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblWorldMarketLog
	{
		public long LogNo { get; set; }
		public int? OperationLogType { get; set; }
		public DateTime? RegisterUtc { get; set; }
		public DateTime? ServerUtc { get; set; }
		public int? NationCode { get; set; }
		public int? ServerNo { get; set; }
		public long? UserNo { get; set; }
		public int? KeyType1 { get; set; }
		public int? MainKey1 { get; set; }
		public int? SubKey1 { get; set; }
		public long? Count1 { get; set; }
		public long? BeforeCount1 { get; set; }
		public long? AfterCount1 { get; set; }
		public long? BeforeCount2 { get; set; }
		public long? AfterCount2 { get; set; }
		public int? KeyType2 { get; set; }
		public int? MainKey2 { get; set; }
		public int? SubKey2 { get; set; }
		public long? Count2 { get; set; }
		public int? Param1 { get; set; }
		public int? Param2 { get; set; }
		public int? Param3 { get; set; }
		public int? Param4 { get; set; }
		public int? Param5 { get; set; }
		public int? Param6 { get; set; }
		public int? Param7 { get; set; }
		public int? Param8 { get; set; }
		public int? Param9 { get; set; }
		public int? Param10 { get; set; }
		public int? Param11 { get; set; }
		public int? Param12 { get; set; }
		public string? TextParam1 { get; set; }
		public string? TextParam2 { get; set; }
		public string? Reason { get; set; }
	}
}
