namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblWorldMarketLogInmem
	{
		public long LogNo { get; set; }
		public int OperationLogType { get; set; }
		public DateTime RegisterUtc { get; set; }
		public DateTime ServerUtc { get; set; }
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
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
		public long? Param1 { get; set; }
		public long? Param2 { get; set; }
		public long? Param3 { get; set; }
		public long? Param4 { get; set; }
		public long? Param5 { get; set; }
		public long? Param6 { get; set; }
		public long? Param7 { get; set; }
		public long? Param8 { get; set; }
		public long? Param9 { get; set; }
		public long? Param10 { get; set; }
		public long? Param11 { get; set; }
		public long? Param12 { get; set; }
		public string? TextParam1 { get; set; }
		public string? TextParam2 { get; set; }
		public short? Reason { get; set; }
	}
}
