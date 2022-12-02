namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 게임서버를 위한 간단한 유저정보
	/// </summary>
	public partial class TblBriefUserInformation
	{
		/// <summary>
		/// 간단 유저정보 최초 등록일시
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 퍼블리셔에서 넘어온 유저번호
		/// </summary>
		public string UserId { get; set; } = null!;
		/// <summary>
		/// 유저별명
		/// </summary>
		public string UserNickname { get; set; } = null!;
		/// <summary>
		/// 최근 로그인시간
		/// </summary>
		public DateTime LastLoginTime { get; set; }
		/// <summary>
		/// 최근 로그아웃시간
		/// </summary>
		public DateTime LastLogoutTime { get; set; }
		/// <summary>
		/// 총 플레이 시간
		/// </summary>
		public long TotalPlayTime { get; set; }
		/// <summary>
		/// PC방 플레이 시간(초)
		/// </summary>
		public long PcRoomPlayTimePerDay { get; set; }
		/// <summary>
		/// PC방 리셋 시간
		/// </summary>
		public DateTime PlayResetTimePerDay { get; set; }
		/// <summary>
		/// 플레이 시간 (초)(하루 동안)
		/// </summary>
		public long PlayTimePerDay { get; set; }
		/// <summary>
		/// PC방 누적 플레이 시간(초)
		/// </summary>
		public long AccumulatePcRoomPlayTime { get; set; }
		/// <summary>
		/// 최근 IP
		/// </summary>
		public string LastIp { get; set; } = null!;
		/// <summary>
		/// 최근 (플레이)캐릭터 번호
		/// </summary>
		public long LastCharacterNo { get; set; }
		/// <summary>
		/// 참이면 PC전환중임
		/// </summary>
		public bool IsPcSwitching { get; set; }
		/// <summary>
		/// 참이면 최초 접속자
		/// </summary>
		public bool? IsFirstLogin { get; set; }
		/// <summary>
		/// 누적 접속 횟수
		/// </summary>
		public int AccumulatedLoginCount { get; set; }
		/// <summary>
		/// 현재 서버 No
		/// </summary>
		public short EnterServerNo { get; set; }
		/// <summary>
		/// 탐험포인트
		/// </summary>
		public int ExplorationPoint { get; set; }
		/// <summary>
		/// 캐릭터를 생성한 횟수
		/// </summary>
		public int CharacterCreationCount { get; set; }
		/// <summary>
		/// PVP가능상태
		/// </summary>
		public bool IsPvpAble { get; set; }
		/// <summary>
		/// 소속영지
		/// </summary>
		public long AffiliatedTerritoryKey { get; set; }
		/// <summary>
		/// 유저정보 갱신번호
		/// </summary>
		public int UserBasicCacheSeqNo { get; set; }
		/// <summary>
		/// 증가된 캐릭터 슬롯 갯수
		/// </summary>
		public short VariedCharacterSlotCount { get; set; }
		/// <summary>
		/// 스타터 패키지 버프 만료일시(널이거나 과거면 버프없음)
		/// </summary>
		public DateTime? StarterPackageBuffExpiration { get; set; }
		/// <summary>
		/// 프리미엄패키지 버프 만료일시(널이거나 과거면 버프없음)
		/// </summary>
		public DateTime? PremiumPackageBuffExpiration { get; set; }
		/// <summary>
		/// 커스터마이징 패키지 버프 만료일시(널이거나 과거면 버프없음)
		/// </summary>
		public DateTime? CustomizationPackageBuffExpiration { get; set; }
		/// <summary>
		/// 펄버프 남은 분=&gt; TOdbcRemainTime 와 연결됨
		/// </summary>
		public int PearlPackageBuffRemainMinute { get; set; }
		/// <summary>
		/// 길드 가입 가능한 날짜.최초 길드 가입할때부터 설정됨,클랜은 해당안됨
		/// </summary>
		public DateTime? GuildJoinableTime { get; set; }
		/// <summary>
		/// 새 친구 여부
		/// </summary>
		public byte NewFriend { get; set; }
		/// <summary>
		/// 친구 요청 여부
		/// </summary>
		public byte NewRequestFriend { get; set; }
		/// <summary>
		/// 마지막으로 말 교환을 진행한 시간
		/// </summary>
		public DateTime? LastServantMixTime { get; set; }
		/// <summary>
		/// 마지막으로 말 구매한 시간
		/// </summary>
		public DateTime? LastServantBuyTime { get; set; }
		/// <summary>
		/// 과거 길드 활동 점수
		/// </summary>
		public int PreGuildActivity { get; set; }
		public string? UserIntroduction { get; set; }
		/// <summary>
		/// 요리/연금 판매 가능 갯수
		/// </summary>
		public long TradeSupplyCount { get; set; }
		/// <summary>
		/// 캐시 아이템 거래소 판매 개수
		/// </summary>
		public short CashItemSaleCount { get; set; }
		/// <summary>
		/// 캐시 아이템 거래소 판매 개수 초기화 시간
		/// </summary>
		public DateTime? CashItemSaleCountResetTime { get; set; }
		/// <summary>
		/// 랜덤 상점 예약 아이템 남은 분
		/// </summary>
		public DateTime RemainKeepTime { get; set; }
		/// <summary>
		/// 랜덤 상점 예약 아이템
		/// </summary>
		public int KeepItemKey { get; set; }
		/// <summary>
		/// 랜덤 상점 예약 아이템 가격배율
		/// </summary>
		public int KeepItemPriceRate { get; set; }
		/// <summary>
		/// 하룻동안 무역으로번 수익
		/// </summary>
		public long AccumulatedAdvantageofTrade { get; set; }
		public int AdventureNo { get; set; }
		public DateTime AdventureExpiration { get; set; }
		public int AdventureTotalScore { get; set; }
		public short AdventureEnd { get; set; }
		/// <summary>
		/// 소속 영지(NULL 이면 소속 없음)
		/// </summary>
		public int? DdTerritoryKey { get; set; }
		/// <summary>
		/// 요정 부활(0이면 사용한적 없음)
		/// </summary>
		public DateTime LastFairyRespawnTime { get; set; }
		/// <summary>
		/// 약탈게임 투표가능 횟수
		/// </summary>
		public short PlunderGameVoteCount { get; set; }
		public byte? PlatformType { get; set; }
		/// <summary>
		/// 토벌게임 재화
		/// </summary>
		public long ExpeditionSupplyPoint { get; set; }
		public bool IsUpdatePremiumBuffBySystem { get; set; }
		public byte FamilyInventorySlotCount { get; set; }
		/// <summary>
		/// 사생활 모드 로그인
		/// </summary>
		public string IsGhostMode { get; set; } = null!;
		public byte SeasonPass { get; set; }
		public int OceanTendency { get; set; }
		public byte DwellingCount { get; set; }
		public int MaxWp { get; set; }
		public int FamilyInventoryWeight { get; set; }
	}
}
