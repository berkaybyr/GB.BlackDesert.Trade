namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblDeletedNameExchange
	{
		public long No { get; set; }
		public DateTime? DeletedDate { get; set; }
		public DateTime RegisterDate { get; set; }
		public long OwnerNo { get; set; }
		public long Character1No { get; set; }
		public string Character2Name { get; set; } = null!;
		public long Character2No { get; set; }
		public string Character1Name { get; set; } = null!;
	}
}
