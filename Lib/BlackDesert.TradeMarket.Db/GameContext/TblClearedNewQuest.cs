namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 퀘스트 완료 목록
	/// </summary>
	public partial class TblClearedNewQuest
	{
		/// <summary>
		/// 1이면 유저 0이면 캐릭터 기반
		/// </summary>
		public bool IsUserBaseQuest { get; set; }
		/// <summary>
		/// 유저캐릭터번호
		/// </summary>
		public long UserCharacterNo { get; set; }
		/// <summary>
		/// _questGroupNo
		/// </summary>
		public int QuestGroupNo { get; set; }
		/// <summary>
		/// 퀘스트번호
		/// </summary>
		public int QuestNo { get; set; }
		/// <summary>
		/// 반복 퀘스트일 경우 초기화될 시간
		/// </summary>
		public DateTime? ResetTime { get; set; }
		/// <summary>
		/// 쾌스트 완료 시간
		/// </summary>
		public DateTime ClearedTime { get; set; }
		public bool IsHideQuestCount { get; set; }
	}
}
