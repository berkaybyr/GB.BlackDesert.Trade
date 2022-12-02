namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 운영 관련 그룹의 역할 테이블
	/// </summary>
	public partial class TblBlockedUser
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
		/// 블록 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 블록 종료 시간
		/// </summary>
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 블록 사유 코드
		/// </summary>
		public int BlockCode { get; set; }
		/// <summary>
		/// 블록 운영자 메모
		/// </summary>
		public string OperationMemo { get; set; } = null!;
		public byte[]? MacAddress { get; set; }
	}
}
