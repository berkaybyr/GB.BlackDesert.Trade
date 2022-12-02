namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 하우징 하우스홀드 고정집 테이블
	/// </summary>
	public partial class TblHouseholdFixed
	{
		/// <summary>
		/// 하우징홀드 번호
		/// </summary>
		public long HouseholdNo { get; set; }
		/// <summary>
		/// 참이면 모든 사람에게 오픈됨
		/// </summary>
		public bool IsOpenedForEverybody { get; set; }
		/// <summary>
		/// 참이면 가입길드원에게 오픈됨
		/// </summary>
		public bool IsOpenedForGuild { get; set; }
		/// <summary>
		/// 참이면 가입연합원에게 오픈됨
		/// </summary>
		public bool IsOpenedForAlliance { get; set; }
		/// <summary>
		/// 설치물 점수 합산
		/// </summary>
		public int InteriorSensePoint { get; set; }
		public DateTime? InteriorUpdateTime { get; set; }
		/// <summary>
		/// 길드하우스 일 경우 경매 낙찰 가격
		/// </summary>
		public long SuccessBidPrice { get; set; }
		public int CharacterKey { get; set; }
	}
}
