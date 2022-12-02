namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemRental
	{
		public long ItemNo { get; set; }
		public long UserNo { get; set; }
		public int ItemKey { get; set; }
		public byte EnchantLevel { get; set; }
		public bool IsSealed { get; set; }
		public DateTime? ExpirationDate { get; set; }
	}
}
