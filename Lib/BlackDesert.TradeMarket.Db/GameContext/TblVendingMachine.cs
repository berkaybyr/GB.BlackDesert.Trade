namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblVendingMachine
	{
		public long HouseholdNo { get; set; }
		public long InstallationNo { get; set; }
		public short VendingIndex { get; set; }
		public int ItemKey { get; set; }
		public byte EnchantLevel { get; set; }
		public bool IsStackable { get; set; }
		public long Count { get; set; }
		public long BuyFromUserPrice { get; set; }
		public long SellToUserPrice { get; set; }
		public long MaxStackCount { get; set; }
	}
}
