namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 일꾼
	/// </summary>
	public partial class TblWorker
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 소유 사용자번호
		/// </summary>
		public long OwnerUserNo { get; set; }
		/// <summary>
		/// _workerNo
		/// </summary>
		public long WorkerNo { get; set; }
		/// <summary>
		/// _characterKey
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 마을(살고 있는 곳)의 PlantKey
		/// </summary>
		public int HomePlantKey { get; set; }
		/// <summary>
		/// 작업 가능 횟수(NULL무제한, 0 행동력소모)
		/// </summary>
		public int? ActionPoint { get; set; }
		/// <summary>
		/// 작업 가능 최대횟수(NULL무제한, 0 행동력소모)
		/// </summary>
		public int? ActionPointMax { get; set; }
		/// <summary>
		/// 일꾼의 레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 현재 경험치
		/// </summary>
		public long Experience { get; set; }
		/// <summary>
		/// 일꾼의 추가 이동속도
		/// </summary>
		public int MoveSpeed { get; set; }
		/// <summary>
		/// 일꾼의 추가 효율
		/// </summary>
		public int WorkEfficience { get; set; }
		/// <summary>
		/// 일꾼의 추가 행운
		/// </summary>
		public int Luck { get; set; }
		/// <summary>
		/// 일꾼의 스킬0
		/// </summary>
		public int SkillKey0 { get; set; }
		/// <summary>
		/// 일꾼의 스킬1
		/// </summary>
		public int SkillKey1 { get; set; }
		/// <summary>
		/// 일꾼의 스킬2
		/// </summary>
		public int SkillKey2 { get; set; }
		/// <summary>
		/// 일꾼의 스킬3
		/// </summary>
		public int SkillKey3 { get; set; }
		/// <summary>
		/// 일꾼의 스킬4
		/// </summary>
		public int SkillKey4 { get; set; }
		/// <summary>
		/// 일꾼의 스킬5
		/// </summary>
		public int SkillKey5 { get; set; }
		/// <summary>
		/// 일꾼의 스킬6
		/// </summary>
		public int SkillKey6 { get; set; }
		/// <summary>
		/// 승급가능 횟수
		/// </summary>
		public byte UpgradePoint { get; set; }
		/// <summary>
		/// 거래소 등록 여부
		/// </summary>
		public bool IsAuctionInsert { get; set; }
		/// <summary>
		/// 삭제여부
		/// </summary>
		public DateTime? DeleteDate { get; set; }
	}
}
