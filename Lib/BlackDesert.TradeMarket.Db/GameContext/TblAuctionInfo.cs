namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 경매장 정보 ( 집 경매 및 용병 경매를 위함 )
	/// </summary>
	public partial class TblAuctionInfo
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 경매장 번호
		/// </summary>
		public int AuctionKey { get; set; }
		/// <summary>
		/// 다음 경매 시간
		/// </summary>
		public long NextStartTime { get; set; }
	}
}
