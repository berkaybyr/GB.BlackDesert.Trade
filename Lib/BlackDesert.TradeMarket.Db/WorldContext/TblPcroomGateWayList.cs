namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPcroomGateWayList
	{
		public byte GatewayServerNo { get; set; }
		public string ServerIp { get; set; } = null!;
		public DateTime LastUpdateDate { get; set; }
		public byte Status { get; set; }
	}
}
