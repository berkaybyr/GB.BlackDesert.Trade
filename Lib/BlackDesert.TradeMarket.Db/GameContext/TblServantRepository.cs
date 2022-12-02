namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// Servant 정보
	/// </summary>
	public partial class TblServantRepository
	{
		/// <summary>
		/// 소유자 타입
		/// </summary>
		public byte WhereType { get; set; }
		/// <summary>
		/// 소유자 고유 번호
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 소유자 유저 고유 번호
		/// </summary>
		public long? OwnerCharacterNo { get; set; }
		/// <summary>
		/// 고유 번호
		/// </summary>
		public long ServantNo { get; set; }
		/// <summary>
		/// 캐릭터 키
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 캐릭터 타입(지상, 수상)
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		public string Name { get; set; } = null!;
		/// <summary>
		/// 경험치
		/// </summary>
		public DateTime? ExpiredTime { get; set; }
		/// <summary>
		/// 등록 일시
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 삭제 일시
		/// </summary>
		public DateTime? DeleteDate { get; set; }
		/// <summary>
		/// 캐싱 시퀀스번호
		/// </summary>
		public int ServantBasicCacheSeqNo { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 경험치
		/// </summary>
		public long Experience { get; set; }
		/// <summary>
		/// 체력
		/// </summary>
		public int Hp { get; set; }
		/// <summary>
		/// 스태미너
		/// </summary>
		public int Mp { get; set; }
		/// <summary>
		/// 교배 횟수
		/// </summary>
		public byte MatingCount { get; set; }
		/// <summary>
		/// 말 상태
		/// </summary>
		public byte StateType { get; set; }
		/// <summary>
		/// _sealRegion
		/// </summary>
		public int? SealRegion { get; set; }
		/// <summary>
		/// 교배 고유 번호
		/// </summary>
		public long? MatingNo { get; set; }
		public int DeadCount { get; set; }
		/// <summary>
		/// 교감쿨타임(밀리초)
		/// </summary>
		public long SympatheticCoolTime { get; set; }
		/// <summary>
		/// 압류(유/무)
		/// </summary>
		public bool IsSeized { get; set; }
		/// <summary>
		/// 각인(유/무)
		/// </summary>
		public bool IsImprint { get; set; }
		/// <summary>
		/// 교배 횟수 추가 아이템 사용 횟수
		/// </summary>
		public byte ClearCountByMating { get; set; }
		/// <summary>
		/// 죽은 횟수 초기화 아이템 사용 횟수
		/// </summary>
		public byte ClearCountByDead { get; set; }
		/// <summary>
		/// 스킬 변경 실패 횟수
		/// </summary>
		public int SkillFailedCount { get; set; }
		/// <summary>
		/// 연결된 마차 번호
		/// </summary>
		public long? OwnerServantNo { get; set; }
		/// <summary>
		/// 외형 인덱스
		/// </summary>
		public int FormIndex { get; set; }
		/// <summary>
		/// 염색
		/// </summary>
		public byte[]? DyeingList { get; set; }
		/// <summary>
		/// _currentFieldNo
		/// </summary>
		public short CurrentFieldNo { get; set; }
		/// <summary>
		/// _currentFieldIndex
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
		/// _variedMaxHp
		/// </summary>
		public int VariedMaxHp { get; set; }
		/// <summary>
		/// _variedMaxMp
		/// </summary>
		public int VariedMaxMp { get; set; }
		/// <summary>
		/// 성장 가변 가속도
		/// </summary>
		public int VariedAcceleration { get; set; }
		/// <summary>
		/// 성장 가변 속도
		/// </summary>
		public int VariedMoveSpeed { get; set; }
		/// <summary>
		/// 성장 가변 코너링
		/// </summary>
		public int VariedCornering { get; set; }
		/// <summary>
		/// 성장 가변 브레이크
		/// </summary>
		public int VariedBrake { get; set; }
		/// <summary>
		/// 스킬 훈련 종료시간
		/// </summary>
		public DateTime? EndSkillExpTrainingTime { get; set; }
		/// <summary>
		/// 소환된 서버 번호
		/// </summary>
		public short? LastServerNo { get; set; }
		/// <summary>
		/// 서번트 소환 가능 시간
		/// </summary>
		public DateTime? UnsealDelayTime { get; set; }
		/// <summary>
		/// 준마 각성 스택
		/// </summary>
		public int AwakenStack { get; set; }
		public int? Food { get; set; }
		public int? StatParam1 { get; set; }
		public int? StatParam2 { get; set; }
		public int? StatParam3 { get; set; }
		public long? RentOwnerNo { get; set; }
		/// <summary>
		/// _direction
		/// </summary>
		public int? Direction { get; set; }
		public DateTime? RentEndDate { get; set; }
		/// <summary>
		/// 성장 가변 대포 쿨타임
		/// </summary>
		public int VariedCannonCoolTime { get; set; }
		/// <summary>
		/// 성장 가변 대포 정확도
		/// </summary>
		public int VariedCannonAccuracy { get; set; }
		/// <summary>
		/// 성장 가변 대포 사거리
		/// </summary>
		public int VariedCannonMaxLength { get; set; }
		/// <summary>
		/// 성장 가변 대포 각도
		/// </summary>
		public int VariedCannonMaxAngle { get; set; }
		public int SkillDiceCount { get; set; }
		public byte UseAccelerationStatItem { get; set; }
		public byte UseMoveSpeedStatItem { get; set; }
		public byte UseCorneringStatItem { get; set; }
		public byte UseBrakeStatItem { get; set; }
	}
}
