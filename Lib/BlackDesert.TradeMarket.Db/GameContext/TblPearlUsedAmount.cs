namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 펄 획득, 사용량 누적내역
	/// </summary>
	public partial class TblPearlUsedAmount
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
		/// 일간 펄 획득량
		/// </summary>
		public long PearlObtainedDaily { get; set; }
		/// <summary>
		/// 일간 펄 사용량
		/// </summary>
		public long PearlUsedDaily { get; set; }
		/// <summary>
		/// 일단위 펄 사용량 리셋 시간
		/// </summary>
		public DateTime DailyResetTime { get; set; }
		/// <summary>
		/// 주간 펄 획득량
		/// </summary>
		public long PearlObtainedWeekly { get; set; }
		/// <summary>
		/// 주간 펄 사용량
		/// </summary>
		public long PearlUsedWeekly { get; set; }
		/// <summary>
		/// 주단위 펄 사용량 리셋 시간
		/// </summary>
		public DateTime WeeklyResetTime { get; set; }
		/// <summary>
		/// 월간 펄 획득량
		/// </summary>
		public long PearlObtainedMonthly { get; set; }
		/// <summary>
		/// 월간 펄 사용량
		/// </summary>
		public long PearlUsedMonthly { get; set; }
		/// <summary>
		/// 월단위 펄 사용량 리셋 시간
		/// </summary>
		public DateTime MonthlyResetTime { get; set; }
		/// <summary>
		/// 총 누적 펄 획득량
		/// </summary>
		public long PearlObtainedTotal { get; set; }
		/// <summary>
		/// 총 누적 펄 사용량
		/// </summary>
		public long PearlUsedTotal { get; set; }
	}
}
