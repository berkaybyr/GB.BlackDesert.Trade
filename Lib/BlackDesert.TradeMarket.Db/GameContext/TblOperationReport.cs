namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblOperationReport
	{
		public byte? Type { get; set; }
		public DateTime RegisterDate { get; set; }
		public long? UserNo { get; set; }
		public string Report { get; set; } = null!;
	}
}
