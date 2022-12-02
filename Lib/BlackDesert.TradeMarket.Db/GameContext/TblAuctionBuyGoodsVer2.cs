namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 경매 구매 테이블(삽니다)
	/// </summary>
	public partial class TblAuctionBuyGoodsVer2
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
		/// 경매장 번호
		/// </summary>
		public int AuctionKey { get; set; }
		/// <summary>
		/// 매입자
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 매입자
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 구매할 아이템 키
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 구매할 아이템 갯수
		/// </summary>
		public long TotalItemCount { get; set; }
		/// <summary>
		/// 구매한 아이템 갯수
		/// </summary>
		public long CurrentItemCount { get; set; }
		/// <summary>
		/// 개당 아이템 갯수
		/// </summary>
		public long ItemPrice { get; set; }
		/// <summary>
		/// 보증금
		/// </summary>
		public long Deposit { get; set; }
		/// <summary>
		/// 구매 종료 시간
		/// </summary>
		public long ExpireTime { get; set; }
		/// <summary>
		/// 경매종료(경매종료 1)
		/// </summary>
		public bool IsAuctionEnd { get; set; }
	}
}
