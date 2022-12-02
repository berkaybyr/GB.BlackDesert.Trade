namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 결전 종료 정보
	/// </summary>
	public partial class TblCompletedPersonalBattle
	{
		/// <summary>
		/// 종료 시간
		/// </summary>
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 시즌
		/// </summary>
		public int Season { get; set; }
		/// <summary>
		/// 결전 고유 번호
		/// </summary>
		public long BattleNo { get; set; }
		/// <summary>
		/// 이긴 팀 번호
		/// </summary>
		public byte WinTeamNo { get; set; }
		/// <summary>
		/// 패배 팀 번호
		/// </summary>
		public byte LoseTeamNo { get; set; }
		/// <summary>
		/// 결전 결과
		/// </summary>
		public short State { get; set; }
	}
}
