namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 칭호 시스템
	/// </summary>
	public partial class TblPlayerTitle
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 칭호 키
		/// </summary>
		public int Key { get; set; }
		/// <summary>
		/// 칭호 카운트
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// 칭호 획득 여부
		/// </summary>
		public bool IsAcquired { get; set; }
		/// <summary>
		/// 칭호 종료시간
		/// </summary>
		public DateTime? ExpirationDate { get; set; }
	}
}
