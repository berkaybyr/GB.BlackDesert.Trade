namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblStockMarketBuy
	{
		/// <summary>
		/// 거래순번
		/// </summary>
		public int MarketId { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		public int RegionKey { get; set; }
		/// <summary>
		/// 구매자
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 아이템 종류
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 구매가격
		/// </summary>
		public int Price { get; set; }
		/// <summary>
		/// 구매수량
		/// </summary>
		public int Count { get; set; }
	}
}
