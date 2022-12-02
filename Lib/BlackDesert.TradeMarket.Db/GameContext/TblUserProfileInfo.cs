namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저 프로파일
	/// </summary>
	public partial class TblUserProfileInfo
	{
		/// <summary>
		/// 초기화 될 시간
		/// </summary>
		public DateTime NextInitDate { get; set; }
		/// <summary>
		/// 업데이트 시간
		/// </summary>
		public DateTime UpdateDate { get; set; }
		/// <summary>
		/// 프로파일 날짜 초기화 간격
		/// </summary>
		public int DateInitTerm { get; set; }
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 몬스터 킬 수
		/// </summary>
		public long Value1 { get; set; }
		/// <summary>
		/// 낚시 성공 횟수
		/// </summary>
		public long Value2 { get; set; }
		/// <summary>
		/// 아이템 획득 횟수
		/// </summary>
		public long Value3 { get; set; }
		/// <summary>
		/// 제작 성공 횟수
		/// </summary>
		public long Value4 { get; set; }
		/// <summary>
		/// 몬스터 킬 수로 아이템 획득
		/// </summary>
		public bool IsRewardGain1 { get; set; }
		/// <summary>
		/// 낚시 성공으로 아이템 획득
		/// </summary>
		public bool IsRewardGain2 { get; set; }
		/// <summary>
		/// 아이템 획득으로 아이템 획득
		/// </summary>
		public bool IsRewardGain3 { get; set; }
		/// <summary>
		/// 제작 성공으로 아이템 획득
		/// </summary>
		public bool IsRewardGain4 { get; set; }
	}
}
