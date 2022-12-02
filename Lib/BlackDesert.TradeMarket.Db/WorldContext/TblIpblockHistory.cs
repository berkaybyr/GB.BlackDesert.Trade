namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblIpblockHistory
	{
		public long BlockNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public string StartIp { get; set; } = null!;
		public string EndIp { get; set; } = null!;
		public int BlockCode { get; set; }
		public string OperationMemo { get; set; } = null!;
	}
}
