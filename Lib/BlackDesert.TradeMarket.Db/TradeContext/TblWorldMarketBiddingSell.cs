namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketBiddingSell
	{
		public long SellNo { get; set; }
		public int KeyType { get; set; }
		public int MainKey { get; set; }
		public int SubKey { get; set; }
		public bool IsSealed { get; set; }
		public int ChooseSubKey { get; set; }
		public long NeedMaterialCount { get; set; }
		public long LeftCount { get; set; }
		public long SoldCount { get; set; }
		public long PricePerOne { get; set; }
		public long AccumulateMoneyCount { get; set; }
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public bool IsRingBuff { get; set; }
	}
}
