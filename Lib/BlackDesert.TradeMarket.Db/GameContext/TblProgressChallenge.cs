namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 진행중-도전과제 및 pc방 정액제
	/// </summary>
	public partial class TblProgressChallenge
	{
		public DateTime? RegisterDate { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 도전과제 키-DataSheet_Challenge$Challenge_Table
		/// </summary>
		public int ChallengeKey { get; set; }
		public int ParamNumber { get; set; }
		public long ParamTime { get; set; }
	}
}
