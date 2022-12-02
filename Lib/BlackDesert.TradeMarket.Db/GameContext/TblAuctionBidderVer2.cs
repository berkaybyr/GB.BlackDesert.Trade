namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 경매 입찰 테이블
	/// </summary>
	public partial class TblAuctionBidderVer2
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 경매상품 번호
		/// </summary>
		public long AuctionGoodsNo { get; set; }
		/// <summary>
		/// 입찰자 유져 번호(입찰 완료)
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 입찰자 유져 번호(입찰 완료)
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 경매장 번호
		/// </summary>
		public int AuctionKey { get; set; }
		/// <summary>
		/// 입찰가
		/// </summary>
		public long BidPrice { get; set; }
		/// <summary>
		/// 낙찰자(-1 입찰중,돈찾아가면 삭제)
		/// </summary>
		public long SuccessBidder { get; set; }
		public long BidPriceOwnerNo { get; set; }
		public byte BidCount { get; set; }
		/// <summary>
		/// 삭제일
		/// </summary>
		public DateTime? DeletedDate { get; set; }
	}
}
