namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저캐릭 메모
	/// </summary>
	public partial class TblCharacterMemo
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 현재 수행중이던 퀘스트 그룹번호
		/// </summary>
		public int? CurrentQuestGroupNo { get; set; }
		/// <summary>
		/// 현재 수행중이던 퀘스트 번호
		/// </summary>
		public int? CurrentQuestNo { get; set; }
		/// <summary>
		/// 마지막 수행중이던 퀘스트 그룹번호
		/// </summary>
		public int? LastQuestGroupNo0 { get; set; }
		/// <summary>
		/// 마지막 수행중이던 퀘스트 번호
		/// </summary>
		public int? LastQuestNo0 { get; set; }
		/// <summary>
		/// 마지막-1 수행중이던 퀘스트 그룹번호
		/// </summary>
		public int? LastQuestGroupNo1 { get; set; }
		/// <summary>
		/// 마지막-1 수행중이던 퀘스트 번호
		/// </summary>
		public int? LastQuestNo1 { get; set; }
		/// <summary>
		/// OdbcUserMemo와 연결됨
		/// </summary>
		public string? Memo { get; set; }
		/// <summary>
		/// 아이템 교환 길찾기 중이던 ItemEnchantKey
		/// </summary>
		public int? CurrentFindExchangeItemEnchantKey { get; set; }
		/// <summary>
		/// 현재 수행중이던 퀘스트 좌표
		/// </summary>
		public float? CurrentQuestPositionX { get; set; }
		/// <summary>
		/// 현재 수행중이던 퀘스트 좌표
		/// </summary>
		public float? CurrentQuestPositionY { get; set; }
		/// <summary>
		/// 현재 수행중이던 퀘스트 좌표
		/// </summary>
		public float? CurrentQuestPositionZ { get; set; }
		/// <summary>
		/// 현재 유저가 설정한 목표 좌표
		/// </summary>
		public float? UserTargetPositionX { get; set; }
		/// <summary>
		/// 현재 유저가 설정한 목표 좌표
		/// </summary>
		public float? UserTargetPositionY { get; set; }
		/// <summary>
		/// 현재 유저가 설정한 목표 좌표
		/// </summary>
		public float? UserTargetPositionZ { get; set; }
	}
}
