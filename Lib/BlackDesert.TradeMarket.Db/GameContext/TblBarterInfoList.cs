namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBarterInfoList
	{
		public long UserNo { get; set; }
		public int RegionKey { get; set; }
		public int FromItemEnchantKey { get; set; }
		public long FromItemCount { get; set; }
		public int ToItemEnchantKey { get; set; }
		public long ToItemCount { get; set; }
		public int CurrentExchangeCount { get; set; }
		public int MaxExchangeCount { get; set; }
		public int ExchangeCountForTime { get; set; }
		public bool IsSpecial { get; set; }
		public long? BarterSeed { get; set; }
		public byte BarterType { get; set; }
	}
}
