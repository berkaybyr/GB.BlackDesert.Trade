namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblBlockType
	{
		public long Index { get; set; }
		public int BlockCode { get; set; }
		public long Duration { get; set; }
		public string BlockReason { get; set; } = null!;
		public bool? IsUse { get; set; }
		public string Memo { get; set; } = null!;
	}
}
