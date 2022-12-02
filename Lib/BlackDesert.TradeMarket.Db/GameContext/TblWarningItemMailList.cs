namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblWarningItemMailList
	{
		public int MailRequestNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public bool IsSended { get; set; }
		public string NoteNo { get; set; } = null!;
		public string UserId { get; set; } = null!;
		public string SenderName { get; set; } = null!;
		public string Title { get; set; } = null!;
		public string Contents { get; set; } = null!;
		public int ItemKey { get; set; }
		public long? ItemCount { get; set; }
		public byte EnchantLevel { get; set; }
		public DateTime? DeletedDate { get; set; }
		public string? NoteUrl { get; set; }
	}
}
