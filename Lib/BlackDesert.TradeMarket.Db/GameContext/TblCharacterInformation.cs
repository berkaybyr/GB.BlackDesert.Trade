namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저캐릭기본정보
	/// </summary>
	public partial class TblCharacterInformation
	{
		/// <summary>
		/// 캐릭터 생성일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 참인 경우에만 선택할 수 있는 캐릭임
		/// </summary>
		public bool? IsValid { get; set; }
		/// <summary>
		/// 캐릭을 소유한 사용자번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 생성된 슬롯번호
		/// </summary>
		public byte SlotNo { get; set; }
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 캐릭터명
		/// </summary>
		public string CharacterName { get; set; } = null!;
		/// <summary>
		/// 삭제될 날짜(NULL이면 삭제시도없는것)
		/// </summary>
		public DateTime? DeletedDate { get; set; }
		/// <summary>
		/// 클래스타입 0 워리어 4 엘프레인저 8 위저드 12 자이언트
		/// </summary>
		public byte ClassType { get; set; }
		/// <summary>
		/// 최근로그인시간
		/// </summary>
		public DateTime LastLoginTime { get; set; }
		/// <summary>
		/// 최근로그아웃시간
		/// </summary>
		public DateTime LastLogoutTime { get; set; }
		/// <summary>
		/// 총 play시간(단위:분)
		/// </summary>
		public long TotalPlayTime { get; set; }
		/// <summary>
		/// 캐릭터 정보 갱신번호
		/// </summary>
		public int PcBasicCacheSeqNo { get; set; }
		public int PcNonSavedCacheSeqNo { get; set; }
		/// <summary>
		/// TFieldNo
		/// </summary>
		public short CurrentFieldNo { get; set; }
		/// <summary>
		/// TFieldIndex
		/// </summary>
		public short CurrentFieldIndex { get; set; }
		/// <summary>
		/// _currentPositionX
		/// </summary>
		public long CurrentPositionX { get; set; }
		/// <summary>
		/// _currentPositionY
		/// </summary>
		public long CurrentPositionY { get; set; }
		/// <summary>
		/// _currentPositionZ
		/// </summary>
		public long CurrentPositionZ { get; set; }
		/// <summary>
		/// TFieldNo
		/// </summary>
		public short ReturnFieldNo { get; set; }
		/// <summary>
		/// TFieldIndex
		/// </summary>
		public short ReturnFieldIndex { get; set; }
		/// <summary>
		/// _returnPositionX
		/// </summary>
		public long ReturnPositionX { get; set; }
		/// <summary>
		/// _returnPositionY
		/// </summary>
		public long ReturnPositionY { get; set; }
		/// <summary>
		/// _returnPositionZ
		/// </summary>
		public long ReturnPositionZ { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 레벨경험치
		/// </summary>
		public long Experience { get; set; }
		/// <summary>
		/// 스킬포인트레벨
		/// </summary>
		public int SkillPointLevel { get; set; }
		/// <summary>
		/// 스킬포인트경험치
		/// </summary>
		public int SkillPointExperience { get; set; }
		/// <summary>
		/// 남은 스킬포인트
		/// </summary>
		public int RemainedSkillPoint { get; set; }
		/// <summary>
		/// 총 획득한 스킬포인트
		/// </summary>
		public int AquiredSkillPoint { get; set; }
		/// <summary>
		/// 스킬포인트경험치
		/// </summary>
		public int ProductSkillPointExperience { get; set; }
		/// <summary>
		/// 남은 스킬포인트
		/// </summary>
		public int RemainedProductSkillPoint { get; set; }
		/// <summary>
		/// 총 획득한 스킬포인트
		/// </summary>
		public int AquiredProductSkillPoint { get; set; }
		/// <summary>
		/// 성향
		/// </summary>
		public int Tendency { get; set; }
		/// <summary>
		/// 현재hp
		/// </summary>
		public int Hp { get; set; }
		/// <summary>
		/// 현재mp
		/// </summary>
		public int Mp { get; set; }
		/// <summary>
		/// 현재sp
		/// </summary>
		public int Sp { get; set; }
		/// <summary>
		/// 현재wp
		/// </summary>
		public int Wp { get; set; }
		/// <summary>
		/// 증감되는 hp통
		/// </summary>
		public int VariedMaxHp { get; set; }
		/// <summary>
		/// 증감되는 mp통
		/// </summary>
		public int VariedMaxMp { get; set; }
		/// <summary>
		/// 증감되는 근거리Hit
		/// </summary>
		public int VariedDirectHit { get; set; }
		/// <summary>
		/// 증감되는 근거리Dv
		/// </summary>
		public int VariedDirectDv { get; set; }
		/// <summary>
		/// 증감되는 근거리Pv
		/// </summary>
		public int VariedDirectPv { get; set; }
		/// <summary>
		/// 증감되는 원거리Hit
		/// </summary>
		public int VariedRangeHit { get; set; }
		/// <summary>
		/// 증감되는 원거리Dv
		/// </summary>
		public int VariedRangeDv { get; set; }
		/// <summary>
		/// 증감되는 원거리Pv
		/// </summary>
		public int VariedRangePv { get; set; }
		/// <summary>
		/// 증감되는 MagicalHit
		/// </summary>
		public int VariedMagicalHit { get; set; }
		/// <summary>
		/// 증감되는 MagicalHit
		/// </summary>
		public int VariedMagicalDv { get; set; }
		/// <summary>
		/// 증감되는 MagicalHit
		/// </summary>
		public int VariedMagicalPv { get; set; }
		/// <summary>
		/// 퀘스트 보상 통합 포인트
		/// </summary>
		public int RewardPoint { get; set; }
		/// <summary>
		/// 퀘스트 보상레벨에 따라 보상을 받아간 마지막 로그
		/// </summary>
		public int QuestLevelLog { get; set; }
		/// <summary>
		/// 내게 도착한 새로운 멜 개수
		/// </summary>
		public byte NewMail { get; set; }
		/// <summary>
		/// 내가 친구를 요청한 것중 상대가 수락한게 개수
		/// </summary>
		public byte NewFriend { get; set; }
		/// <summary>
		/// 나에게 친구를 요청한 개수
		/// </summary>
		public byte NewRequestFriend { get; set; }
		/// <summary>
		/// 계정내의 캐릭터 생성순서
		/// </summary>
		public int CreationIndex { get; set; }
		/// <summary>
		/// 추가 인벤 슬롯 숫자
		/// </summary>
		public byte InventorySlotCount { get; set; }
		/// <summary>
		/// 배우려는 예약 스킬의 키값
		/// </summary>
		public int ReservedLearningSkillKey { get; set; }
		/// <summary>
		/// 내가 탑승(인터렉션을 통한) 중인 탈것의 타입
		/// </summary>
		public bool IsRideTypeServant { get; set; }
		/// <summary>
		/// 내가 탑승(인터렉션을 통한) 중인 탈것의 고유 번호
		/// </summary>
		public long RideVariousNo { get; set; }
		/// <summary>
		/// 내가 탑승(인터렉션을 통한) 중인 탈것의 시트 번호
		/// </summary>
		public byte RideSeatIndex { get; set; }
		/// <summary>
		/// 내가 올라가 있는 탈것의 타입
		/// </summary>
		public bool IsOnTypeServant { get; set; }
		/// <summary>
		/// 내가 올라가 있는 탈것의 고유 번호
		/// </summary>
		public long OnVariousNo { get; set; }
		/// <summary>
		/// 영구적으로 늘어난 무게
		/// </summary>
		public int VariedWeight { get; set; }
		/// <summary>
		/// 적용한 칭호키(0은 칭호 없음)
		/// </summary>
		public int TitleKey { get; set; }
		/// <summary>
		/// 킬 보상(블랙스톤)
		/// </summary>
		public int KillRewardCount { get; set; }
		/// <summary>
		/// 인챈트실패횟수
		/// </summary>
		public int EnchantFailCount { get; set; }
		/// <summary>
		/// PC방 인챈트 카운트
		/// </summary>
		public int EnchantPcRoomCount { get; set; }
		/// <summary>
		/// 강화실패시 장비 파괴 보호
		/// </summary>
		public int EnchantProtectBrokenCount { get; set; }
		/// <summary>
		/// 이동될 지역 번호
		/// </summary>
		public int ArrivalRegionKey { get; set; }
		/// <summary>
		/// 도착 시간
		/// </summary>
		public DateTime? ArrivalTime { get; set; }
		public int EnchantValuePackCount { get; set; }
		public int RankPointPvp { get; set; }
		public int AccumulatedKillCountByLocalWar { get; set; }
		public long RestoreExperience { get; set; }
		public long MurdererStateEndTime { get; set; }
		public int? LastBiddingItemKey { get; set; }
		public int BiddingFailCount { get; set; }
		/// <summary>
		/// 일반 스킬 각성한 횟수
		/// </summary>
		public int SkillAwakeningCount { get; set; }
		/// <summary>
		/// 각성무기 스킬 각성한 횟수
		/// </summary>
		public int WeaponSkillAwakeningCount { get; set; }
		/// <summary>
		/// 특별 케릭터인가
		/// </summary>
		public bool IsSpecialCharacter { get; set; }
		/// <summary>
		/// 캐릭터 공격력
		/// </summary>
		public int OffenceValue { get; set; }
		/// <summary>
		/// 캐릭터 방어력
		/// </summary>
		public int DefenceValue { get; set; }
		/// <summary>
		/// 캐릭터 각성공격력
		/// </summary>
		public int AwakenValue { get; set; }
		/// <summary>
		/// 듀얼캐릭터
		/// </summary>
		public long DuelCharacterNo { get; set; }
		public int DuelRegionKey { get; set; }
		/// <summary>
		/// 강화 스택 경험치
		/// </summary>
		public long EnchantFailCountExp { get; set; }
		/// <summary>
		/// 전승 스킬 각성한 횟수
		/// </summary>
		public int SuccessionSkillAwakeningCount { get; set; }
		public int InjuryHp { get; set; }
		public byte SeasonType { get; set; }
		public bool IsEventCharacter { get; set; }
		public short LastEnterServerNo { get; set; }
	}
}
