namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 운영 관련 그룹의 역할 테이블
	/// </summary>
	public partial class TblBlockedChat
	{
		/// <summary>
		/// 블록 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 블록 고유 번호
		/// </summary>
		public long BlockNo { get; set; }
		/// <summary>
		/// 블록 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 블록 종료 시간
		/// </summary>
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 블록 사유
		/// </summary>
		public string ReasonMemo { get; set; } = null!;
	}
}
