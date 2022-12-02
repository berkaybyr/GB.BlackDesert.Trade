namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMassMailRequest
	{
		public long MailRequestNo { get; set; }
		public DateTime? RegisterDate { get; set; }
		public bool? IsAllUser { get; set; }
		public string? UserIdString { get; set; }
		public int? UserIdCount { get; set; }
		public string? SenderName { get; set; }
		public string? Title { get; set; }
		public string? Contents { get; set; }
		public int? ItemKey { get; set; }
		public long? ItemCount { get; set; }
		public byte? EnchantLevel { get; set; }
		public DateTime? DeletedDate { get; set; }
		public long? SendingWaitingNo { get; set; }
		public bool? IsComplete { get; set; }
	}
}
