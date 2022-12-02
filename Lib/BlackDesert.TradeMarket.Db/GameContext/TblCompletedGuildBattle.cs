namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 결전 종료 정보
	/// </summary>
	public partial class TblCompletedGuildBattle
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
		/// 이긴 길드 번호
		/// </summary>
		public long WinGuildNo { get; set; }
		/// <summary>
		/// 패배 길드 번호
		/// </summary>
		public long LoseGuildNo { get; set; }
		/// <summary>
		/// 해당 결전 상금
		/// </summary>
		public long State { get; set; }
	}
}
