namespace BlackDesert.TradeMarket.Db.LogContext
{
	public partial class TblLogReasonGroupName
	{
		public short LogReasonGroupNo { get; set; }
		public string LogReasonGroupName { get; set; } = null!;
		public string LogReasonGroupMemo { get; set; } = null!;
	}
}
