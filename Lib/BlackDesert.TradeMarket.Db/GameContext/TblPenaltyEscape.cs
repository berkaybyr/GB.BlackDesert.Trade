namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPenaltyEscape
	{
		public int InstanceFieldKey { get; set; }
		public long UserNo { get; set; }
		public int StackCount { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
