namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아이템거래소 master
	/// </summary>
	public partial class TblItemMarketMaster
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public DateTime LastUpdateDate { get; set; }
		public int ItemKey { get; set; }
		public long MinPrice { get; set; }
		public long MaxPrice { get; set; }
		public long TradedTotalPrice { get; set; }
		public long TradedTotalAmount { get; set; }
		public long AccumulatedPrice { get; set; }
		public long AccumulatedAmount { get; set; }
	}
}
