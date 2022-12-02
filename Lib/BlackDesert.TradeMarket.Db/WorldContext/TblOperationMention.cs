namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblOperationMention
	{
		public long MentionNo { get; set; }
		public byte Type { get; set; }
		public string Mention { get; set; } = null!;
		public DateTime? RegisterDate { get; set; }
		public short ResourceType { get; set; }
	}
}
