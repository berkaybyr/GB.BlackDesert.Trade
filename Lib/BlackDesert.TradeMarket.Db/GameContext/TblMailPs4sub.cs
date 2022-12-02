namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMailPs4sub
	{
		public DateTime RegisterDate { get; set; }
		public long? MailNo { get; set; }
		public string EntitlementId { get; set; } = null!;
		public bool IsBundleProduct { get; set; }
	}
}
