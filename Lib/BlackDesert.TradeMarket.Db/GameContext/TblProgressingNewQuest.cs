namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 퀘스트 진행 목록
	/// </summary>
	public partial class TblProgressingNewQuest
	{
		/// <summary>
		/// 1이면 유저 0이면 캐릭터 기반
		/// </summary>
		public bool IsUserBaseQuest { get; set; }
		/// <summary>
		/// 유저,캐릭터번호
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
		/// _count1
		/// </summary>
		public int Count1 { get; set; }
		/// <summary>
		/// _count2
		/// </summary>
		public int Count2 { get; set; }
		/// <summary>
		/// _count3
		/// </summary>
		public int Count3 { get; set; }
		/// <summary>
		/// _count4
		/// </summary>
		public int Count4 { get; set; }
		/// <summary>
		/// _count5
		/// </summary>
		public int Count5 { get; set; }
		/// <summary>
		/// _orderTime
		/// </summary>
		public DateTime OrderTime { get; set; }
	}
}
