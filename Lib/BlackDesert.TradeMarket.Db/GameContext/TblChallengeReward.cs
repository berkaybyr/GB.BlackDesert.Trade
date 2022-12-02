namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 도전과제 및 pc방 정액제
	/// </summary>
	public partial class TblChallengeReward
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
		/// 횟수
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// 보상을 중복해서 줄수 있는가 여부
		/// </summary>
		public bool IsOverlapable { get; set; }
	}
}
