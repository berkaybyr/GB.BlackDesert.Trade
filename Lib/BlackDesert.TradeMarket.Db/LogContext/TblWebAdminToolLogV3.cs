namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblWebAdminToolLogV3
	{
		public DateTime RegisterDate { get; set; }
		public long LogNo { get; set; }
		public long? AccountNo { get; set; }
		public long? UserNo { get; set; }
		public string UserIp { get; set; } = null!;
		public int LogType { get; set; }
		public int Reason { get; set; }
		public string ExecuteSpName { get; set; } = null!;
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
		public string? StringParam1 { get; set; }
		public string? StringParam2 { get; set; }
		public string? StringParam3 { get; set; }
		public int? Rv { get; set; }
	}
}
