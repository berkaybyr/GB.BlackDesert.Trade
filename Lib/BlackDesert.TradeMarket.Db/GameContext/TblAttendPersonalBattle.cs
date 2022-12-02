namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 개인 결전 참여 정보
	/// </summary>
	public partial class TblAttendPersonalBattle
	{
		/// <summary>
		/// 결전 번호
		/// </summary>
		public long BattleNo { get; set; }
		/// <summary>
		/// 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 참여 상태
		/// </summary>
		public short TeamNo { get; set; }
	}
}
