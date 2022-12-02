namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserItemLoanLog
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public long ItemNo { get; set; }
		public int ItemKey { get; set; }
		public byte? EnchantLevel { get; set; }
		public long? OwnerNo { get; set; }
		public byte? ItemWhereType { get; set; }
		public long? BeforeCount { get; set; }
		public long? VariedCount { get; set; }
	}
}
