namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPcroomLoginList
	{
		public byte GatewayServerNo { get; set; }
		public long UserNo { get; set; }
		public string SessionNo { get; set; } = null!;
		public byte Status { get; set; }
		public DateTime IngameUpdateDate { get; set; }
		public DateTime GussUpdateDate { get; set; }
		public byte[] MachineId { get; set; } = null!;
		public string ClientIp { get; set; } = null!;
		public string LocalIp { get; set; } = null!;
		public byte? Reason { get; set; }
	}
}
