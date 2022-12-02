namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아이템 구매 갯수 저장
	/// </summary>
	public partial class TblCashItemBuyCount
	{
		/// <summary>
		/// 유저번호인가?
		/// </summary>
		public bool IsUserNo { get; set; }
		/// <summary>
		/// 유저번호&amp;캐릭터번호(_isUserNo가 참이면 유저번호임)
		/// </summary>
		public long UserCharacterNo { get; set; }
		/// <summary>
		/// 캐시상품키
		/// </summary>
		public int CashProductNo { get; set; }
		/// <summary>
		/// 구매량
		/// </summary>
		public int Count { get; set; }
		public long ResetTime { get; set; }
		public bool Type { get; set; }
	}
}
