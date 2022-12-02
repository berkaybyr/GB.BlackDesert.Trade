namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 출석 테이블(매달 초기화됨)
	/// </summary>
	public partial class TblAttendance
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 출석키
		/// </summary>
		public int AttendanceKey { get; set; }
		/// <summary>
		/// 출석일수(한달간)
		/// </summary>
		public int AttendanceCount { get; set; }
		/// <summary>
		/// 출석 보상수령
		/// </summary>
		public int ReceivedReward { get; set; }
		/// <summary>
		/// 출석한 시간
		/// </summary>
		public DateTime OnAttendanceTime { get; set; }
		/// <summary>
		/// 중복 출석 횟수
		/// </summary>
		public int OverlapCount { get; set; }
	}
}
