namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 완료-도전과제 및 pc방 정액제
	/// </summary>
	public partial class TblCompletedChallenge
	{
		public DateTime? RegisterDate { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 도전과제 키 -DataSheet_Challenge$Challenge_Table
		/// </summary>
		public int ChallengeKey { get; set; }
		/// <summary>
		/// 초기화 시간
		/// </summary>
		public DateTime? ResetTime { get; set; }
	}
}
