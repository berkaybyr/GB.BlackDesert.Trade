namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 결전 랭크 정보
	/// </summary>
	public partial class TblGuildBattleRanking
	{
		/// <summary>
		/// 길드 넘버
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 시즌
		/// </summary>
		public int Season { get; set; }
		/// <summary>
		/// 승리
		/// </summary>
		public int Win { get; set; }
		/// <summary>
		/// 패배
		/// </summary>
		public int Lose { get; set; }
		/// <summary>
		/// 길드 점수
		/// </summary>
		public long GuildBattleRating { get; set; }
	}
}
