namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 연인 테이블
	/// </summary>
	public partial class TblLoverList
	{
		/// <summary>
		/// npc 번호
		/// </summary>
		public int NpcKey { get; set; }
		/// <summary>
		/// npc의 연인 유저 번호
		/// </summary>
		public long UserNo { get; set; }
	}
}
