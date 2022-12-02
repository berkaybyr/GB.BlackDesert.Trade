namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketBiddingBuy
	{
		public long BuyNo { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public int ChooseSubKey { get; set; }
		public long NeedMaterialCount { get; set; }
		public long LeftCount { get; set; }
		public long BoughtCount { get; set; }
		public long PricePerOne { get; set; }
		public long AddEnchantPrice { get; set; }
		public long RegisterMoneyCount { get; set; }
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public bool IsCashCategory { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
