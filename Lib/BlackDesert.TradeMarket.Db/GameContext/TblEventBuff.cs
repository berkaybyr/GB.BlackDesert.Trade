namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 이벤트 버프를 저장하기 위한 테이블
	/// </summary>
	public partial class TblEventBuff
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 서버 번호
		/// </summary>
		public short ServerNo { get; set; }
		/// <summary>
		/// 버프 타입
		/// </summary>
		public short BuffType { get; set; }
		/// <summary>
		/// 버프의 퍼센트
		/// </summary>
		public int BuffPercent { get; set; }
		/// <summary>
		/// 버프의 남은 시간
		/// </summary>
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// 범용 변수1
		/// </summary>
		public long Param1 { get; set; }
		/// <summary>
		/// 범용 변수2
		/// </summary>
		public long Param2 { get; set; }
	}
}
