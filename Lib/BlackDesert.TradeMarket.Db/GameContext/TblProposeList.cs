namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 고백 리스트 테이블
	/// </summary>
	public partial class TblProposeList
	{
		/// <summary>
		/// 고백한 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// npc 번호
		/// </summary>
		public int NpcKey { get; set; }
	}
}
