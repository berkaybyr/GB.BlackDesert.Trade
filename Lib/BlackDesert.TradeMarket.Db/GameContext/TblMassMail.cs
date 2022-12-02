namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMassMail
	{
		public long MassMailNo { get; set; }
		public string SenderName { get; set; } = null!;
		public string Title { get; set; } = null!;
		public long? ItemKey { get; set; }
		public long? ItemCount { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime? DeletedDate { get; set; }
		public string Contents { get; set; } = null!;
	}
}
