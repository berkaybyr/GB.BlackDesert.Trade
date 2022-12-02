namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlockedItemLog
	{
		public DateTime? RegisterDate { get; set; }
		public DateTime? DetachDate { get; set; }
		public long? BlockNo { get; set; }
		public long? UserNo { get; set; }
		public string? ReasonMemo { get; set; }
		public long? AttachUserNo { get; set; }
		public long? DetachUserNo { get; set; }
		public bool? ActionType { get; set; }
	}
}
