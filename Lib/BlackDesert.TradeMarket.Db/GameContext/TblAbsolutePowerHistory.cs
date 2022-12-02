namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 절대권력이력
	/// </summary>
	public partial class TblAbsolutePowerHistory
	{
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterTime { get; set; }
		/// <summary>
		/// 운영자 번호
		/// </summary>
		public long OperatorNo { get; set; }
		/// <summary>
		/// 대상 유저
		/// </summary>
		public long TargetUserNo { get; set; }
		/// <summary>
		/// 저주 건 사유
		/// </summary>
		public string? Comment { get; set; }
		/// <summary>
		/// 적용된 저주 들
		/// </summary>
		public string Curses { get; set; } = null!;
		/// <summary>
		/// 저주 종료 시간
		/// </summary>
		public DateTime CurseTime { get; set; }
	}
}
