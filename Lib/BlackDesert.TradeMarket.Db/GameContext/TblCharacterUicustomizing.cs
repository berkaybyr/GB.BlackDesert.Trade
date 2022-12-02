namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저 캐릭을 위한 UI Customizing정보
	/// </summary>
	public partial class TblCharacterUicustomizing
	{
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 퀵슬롯 데이터
		/// </summary>
		public string QuickSlotSerializedData { get; set; } = null!;
		/// <summary>
		/// 퀘스트 데이터
		/// </summary>
		public string QuestSerializedData { get; set; } = null!;
		/// <summary>
		/// 퀘스트 선택 타입
		/// </summary>
		public string QuestSelectType { get; set; } = null!;
		/// <summary>
		/// 퀘스트 정렬 타입
		/// </summary>
		public string QuestSortType { get; set; } = null!;
	}
}
