namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 타임어택 TOP 랭킹
	/// </summary>
	public partial class TblTimeAttackRanking
	{
		/// <summary>
		/// 타입
		/// </summary>
		public int Type { get; set; }
		/// <summary>
		/// 타임어택 소유주
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 몬스터
		/// </summary>
		public int MonsterNo { get; set; }
		/// <summary>
		/// 완료 시간
		/// </summary>
		public long CompleteTime { get; set; }
	}
}
