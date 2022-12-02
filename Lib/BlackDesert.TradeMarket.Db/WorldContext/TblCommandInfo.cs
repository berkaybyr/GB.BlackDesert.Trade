namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblCommandInfo
	{
		public long CommandNo { get; set; }
		public int WorldNo { get; set; }
		public int ServerNo { get; set; }
		public DateTime? RegisterDate { get; set; }
		public string? CommandString { get; set; }
		public byte? Status { get; set; }
		public DateTime? ReserveDate { get; set; }
		public long? Interval { get; set; }
		public byte Type { get; set; }
		public bool IsCycleCommand { get; set; }
		public DateTime EndDate { get; set; }
	}
}
