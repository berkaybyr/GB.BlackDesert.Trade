namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 투표 테이블
	/// </summary>
	public partial class TblVote
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 투표한 자신
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 후보자 캐릭터번호
		/// </summary>
		public long ToCharacterNo { get; set; }
	}
}
