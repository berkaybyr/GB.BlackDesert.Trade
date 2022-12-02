namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBarterUserInfo
	{
		public long UserNo { get; set; }
		public long BarterSeed { get; set; }
		public int BarterStack { get; set; }
		public DateTime? NextUpdateDate { get; set; }
		public int TotalExchangeCount { get; set; }
		public int ExchangeCountForTime { get; set; }
		public int LastExchangeCount { get; set; }
		public DateTime UseItemTime { get; set; }
		public DateTime UseAddCountItemTime { get; set; }
		public int ChangeSeedCountForDay { get; set; }
		public DateTime LastResetTime { get; set; }
		public int NormalSeedChangeCountForDay { get; set; }
		public int MaterialSeedChangeCountForDay { get; set; }
		public byte BarterType { get; set; }
	}
}
