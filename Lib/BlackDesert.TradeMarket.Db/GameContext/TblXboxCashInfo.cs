namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 캐쉬정보
	/// </summary>
	public partial class TblXboxCashInfo
	{
		/// <summary>
		/// 생성일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 계정 번호
		/// </summary>
		public string AccountNo { get; set; } = null!;
		/// <summary>
		/// xbox 에서 구매한 상품 개수 (누적 수량, remarks 참고)
		/// </summary>
		public long ProductCount { get; set; }
		/// <summary>
		/// 사용한 상품 개수 (누적 수량, remarks 참고)
		/// </summary>
		public long ConsumeCount { get; set; }
		/// <summary>
		/// 상품 넘버
		/// </summary>
		public string LegacyProductId { get; set; } = null!;
	}
}
