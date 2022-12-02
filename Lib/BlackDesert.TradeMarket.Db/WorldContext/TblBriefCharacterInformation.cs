namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 캐릭터 요약정보
	/// </summary>
	public partial class TblBriefCharacterInformation
	{
		/// <summary>
		/// 참인 경우에만 선택할 수 있는 캐릭터
		/// </summary>
		public bool? IsValid { get; set; }
		/// <summary>
		/// 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 월드 번호
		/// </summary>
		public short WorldNo { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 캐릭터 명
		/// </summary>
		public string? CharacterName { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		public int? Level { get; set; }
		/// <summary>
		/// 생성일
		/// </summary>
		public DateTime? CreateDate { get; set; }
		/// <summary>
		/// 삭제일
		/// </summary>
		public DateTime? DeletedDate { get; set; }
		/// <summary>
		/// 최종 로그인
		/// </summary>
		public DateTime? LastLoginTime { get; set; }
		/// <summary>
		/// 최종 로그아웃
		/// </summary>
		public DateTime? LastLogoutTime { get; set; }
		/// <summary>
		/// 총 플레이시간(분)
		/// </summary>
		public long? TotalPlayTime { get; set; }
		/// <summary>
		/// 메인 캐릭터여부
		/// </summary>
		public bool? IsMain { get; set; }
		/// <summary>
		/// 클래스
		/// </summary>
		public byte? ClassType { get; set; }
		/// <summary>
		/// 소속영지
		/// </summary>
		public long? AffiliatedTerritoryKey { get; set; }
	}
}
