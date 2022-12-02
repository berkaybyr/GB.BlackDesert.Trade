namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 후보자 리스트 테이블
	/// </summary>
	public partial class TblCandidateList
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 후보자 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 후보자 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 클래스 타입
		/// </summary>
		public byte ClassType { get; set; }
		/// <summary>
		/// 투표 수
		/// </summary>
		public long VoteCount { get; set; }
		public byte Resign { get; set; }
	}
}
