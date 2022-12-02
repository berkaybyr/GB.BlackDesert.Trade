namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPcroomRequestList
	{
		public byte? GatewayServerNo { get; set; }
		public long UserNo { get; set; }
		public string? SessionNo { get; set; }
		public byte RequestType { get; set; }
		public DateTime? RegistDate { get; set; }
		public byte? DoState { get; set; }
		public byte[] MachineId { get; set; } = null!;
		public string ClientIp { get; set; } = null!;
		public string LocalIp { get; set; } = null!;
	}
}
