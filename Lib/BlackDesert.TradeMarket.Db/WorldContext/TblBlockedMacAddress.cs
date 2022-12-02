namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblBlockedMacAddress
	{
		public int Id { get; set; }
		public string MacAddress { get; set; } = null!;
		public long? UserNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime? EndDate { get; set; }
		public string? ReasonMemo { get; set; }
		public int BlockCode { get; set; }
	}
}
