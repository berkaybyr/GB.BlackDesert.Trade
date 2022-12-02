namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblAutoBuyBlockedItem
	{
		public int Id { get; set; }
		public long ItemKey { get; set; }
		public byte EnchantLevel { get; set; }
	}
}
