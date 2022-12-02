namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemMarketSellByParty
	{
		public DateTime RegisterTime { get; set; }
		public long ItemMarketNo { get; set; }
		public long RegisterUserNo0 { get; set; }
		public long? RegisterUserNo1 { get; set; }
		public long? RegisterUserNo2 { get; set; }
		public long? RegisterUserNo3 { get; set; }
		public long? RegisterUserNo4 { get; set; }
		public int ItemEnchantKey { get; set; }
		public long Price { get; set; }
	}
}
