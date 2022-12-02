namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아이템거래소 판매
	/// </summary>
	public partial class TblItemMarketSell
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public long ItemMarketNo { get; set; }
		public long RegisterUserNo { get; set; }
		public long ItemNo { get; set; }
		public int ItemKey { get; set; }
		public long RegisterTerritory { get; set; }
		public long OnePrice { get; set; }
		public long TotalCount { get; set; }
		public long LeftCount { get; set; }
		public DateTime DisplayedBeginDate { get; set; }
		public DateTime DisplayedEndDate { get; set; }
		public long TradedTotalPrice { get; set; }
		public long BidderUserNo { get; set; }
		public int BidderDicePercent { get; set; }
		public int? TradePassword { get; set; }
	}
}
