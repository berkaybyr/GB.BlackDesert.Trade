namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketWallet
	{
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public bool IsSealed { get; set; }
		public long Count { get; set; }
	}
}
