namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblBlockItem
	{
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
