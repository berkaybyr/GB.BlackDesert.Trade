namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPearlInventoryDeletedItemRestoreLog
	{
		public DateTime? RegisterDate { get; set; }
		public long? ItemNo { get; set; }
		public long? NewItemNo { get; set; }
		public long? OwnerNo { get; set; }
		public long? ItemKey { get; set; }
		public string? SymNo { get; set; }
	}
}
