namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlockUsingPointByUser
	{
		public long BlockNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public string? ReasonMemo { get; set; }
	}
}
