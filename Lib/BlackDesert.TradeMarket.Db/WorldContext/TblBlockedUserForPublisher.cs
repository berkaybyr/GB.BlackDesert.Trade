namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 북미 블록 유저 테이블
	/// </summary>
	public partial class TblBlockedUserForPublisher
	{
		/// <summary>
		/// 블록 고유 번호
		/// </summary>
		public long BlockNo { get; set; }
		/// <summary>
		/// 블록 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저 넘버
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 유저 이름
		/// </summary>
		public string CharacterName { get; set; } = null!;
		/// <summary>
		/// 블록 타입
		/// </summary>
		public int BlockType { get; set; }
		/// <summary>
		/// 블록 코드
		/// </summary>
		public int? BlockCode { get; set; }
		/// <summary>
		/// 블록 사유
		/// </summary>
		public string OperationMemo { get; set; } = null!;
		/// <summary>
		/// 블록 종료 시간
		/// </summary>
		public int BlockDuration { get; set; }
		/// <summary>
		/// 북미 서버 넘버
		/// </summary>
		public int ServerNo { get; set; }
		public bool Check { get; set; }
	}
}
