namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드기본정보
	/// </summary>
	public partial class TblGuild
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public DateTime LastActiveDate { get; set; }
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 길드명
		/// </summary>
		public string GuildName { get; set; } = null!;
		/// <summary>
		/// 길드 기본 정보 캐쉬
		/// </summary>
		public int GuildBasicCacheSeqNo { get; set; }
		/// <summary>
		/// 길드마스터 사용자번호
		/// </summary>
		public long MasterUserNo { get; set; }
		/// <summary>
		/// 길드마스터 가문명
		/// </summary>
		public string? MasterUserNickname { get; set; }
		/// <summary>
		/// _skillPointLevel
		/// </summary>
		public int SkillPointLevel { get; set; }
		/// <summary>
		/// _remainedSkillPoint
		/// </summary>
		public int RemainedSkillPoint { get; set; }
		/// <summary>
		/// _aquiredSkillPoint
		/// </summary>
		public int AquiredSkillPoint { get; set; }
		/// <summary>
		/// _skillExperience
		/// </summary>
		public long SkillExperience { get; set; }
		public DateTime? GuildMarkRegisterTime { get; set; }
		/// <summary>
		/// _guildMarkSeqNo
		/// </summary>
		public int GuildMarkSeqNo { get; set; }
		/// <summary>
		/// 길드마크
		/// </summary>
		public byte[]? GuildMark { get; set; }
		/// <summary>
		/// 길드인원변화량
		/// </summary>
		public int VariedMemberCount { get; set; }
		/// <summary>
		/// 길드보호인원변화량
		/// </summary>
		public int VariedProtectMemberCount { get; set; }
		/// <summary>
		/// 길드성향
		/// </summary>
		public int Tendency { get; set; }
		/// <summary>
		/// 길드등급
		/// </summary>
		public byte GuildGrade { get; set; }
		/// <summary>
		/// 법인세를 못 낸 경고 횟수(법인세 납부시 0으로 초기화됨)
		/// </summary>
		public byte TaxWarningCount { get; set; }
		/// <summary>
		/// 미납된 누적 법인세
		/// </summary>
		public long AccumulateTax { get; set; }
		/// <summary>
		/// 인센티브 지급날짜
		/// </summary>
		public DateTime? IncentiveDate { get; set; }
		/// <summary>
		/// 길드하우스유지비
		/// </summary>
		public long AccumulateHouseCost { get; set; }
		/// <summary>
		/// 일일 가능 길드 퀘스트
		/// </summary>
		public byte AvailableGuildQuestCount { get; set; }
		/// <summary>
		/// 길드 공지사항
		/// </summary>
		public string? GuildNotice { get; set; }
		public string? GuildIntroduction { get; set; }
		/// <summary>
		/// 길드 복지자금 전달
		/// </summary>
		public bool GuildWelfare { get; set; }
		/// <summary>
		/// 점령전 체력 감소 스택
		/// </summary>
		public string SiegeDecreaseHpStack { get; set; } = null!;
		/// <summary>
		/// 지난 주 점령전 점령 여부
		/// </summary>
		public string IsOccupyLastWeek { get; set; } = null!;
		public long? AdviserUserNo { get; set; }
		public short GuildMainServerGroupNo { get; set; }
		public DateTime GuildMainServerRegisterDate { get; set; }
	}
}
