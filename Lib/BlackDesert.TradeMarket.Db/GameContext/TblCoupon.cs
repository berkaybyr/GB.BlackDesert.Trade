namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 쿠폰 테이블
	/// </summary>
	public partial class TblCoupon
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		public long CouponNo { get; set; }
		/// <summary>
		/// 쿠폰키
		/// </summary>
		public int CouponKey { get; set; }
		/// <summary>
		/// 쿠폰 만료 일시
		/// </summary>
		public DateTime ExpirationDate { get; set; }
		/// <summary>
		/// 쿠폰 사용 일시
		/// </summary>
		public DateTime? UseDate { get; set; }
		/// <summary>
		/// 쿠폰 상태
		/// </summary>
		public byte State { get; set; }
	}
}
