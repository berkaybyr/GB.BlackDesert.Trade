namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlockItem
	{
		public long BlockNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public int ItemKey { get; set; }
		public string? ReasonMemo { get; set; }
	}
}
