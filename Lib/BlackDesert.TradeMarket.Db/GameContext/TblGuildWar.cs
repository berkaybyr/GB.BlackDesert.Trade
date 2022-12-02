namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 전쟁 정보
	/// </summary>
	public partial class TblGuildWar
	{
		/// <summary>
		/// 전쟁 시작 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 길드 번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 전쟁 선포한 길드 번호
		/// </summary>
		public long TargetGuildNo { get; set; }
		/// <summary>
		/// 킬수
		/// </summary>
		public int Kill { get; set; }
		/// <summary>
		/// 사망수
		/// </summary>
		public int Death { get; set; }
		/// <summary>
		/// 전쟁 페널티 누적 수치
		/// </summary>
		public int PenaltyCount { get; set; }
		/// <summary>
		/// 전쟁 페널티 마지막 갱신 시간
		/// </summary>
		public DateTime LastUpdatePenaltyDate { get; set; }
	}
}
