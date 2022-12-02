namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 결전 정보
	/// </summary>
	public partial class TblProgressingGuildDuel
	{
		/// <summary>
		/// 길드 결전 번호
		/// </summary>
		public long DuelNo { get; set; }
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 결전 선포한 길드 번호
		/// </summary>
		public long DeclareGuildNo { get; set; }
		/// <summary>
		/// 결전 수락한 길드 번호
		/// </summary>
		public long AcceptGuildNo { get; set; }
		/// <summary>
		/// 목표 킬수
		/// </summary>
		public int TargetKill { get; set; }
		/// <summary>
		/// 상금
		/// </summary>
		public long Prize { get; set; }
		/// <summary>
		/// 선포한 길드가 죽인 횟수
		/// </summary>
		public int DeclareGuildKill { get; set; }
		/// <summary>
		/// 마감 시간
		/// </summary>
		public DateTime Deadline { get; set; }
		/// <summary>
		/// 수락한 길드가 죽인 횟수
		/// </summary>
		public int AcceptGuildKill { get; set; }
	}
}
