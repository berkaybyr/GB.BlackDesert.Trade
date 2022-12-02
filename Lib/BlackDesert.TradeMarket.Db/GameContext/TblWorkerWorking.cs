namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 일꾼 작업
	/// </summary>
	public partial class TblWorkerWorking
	{
		/// <summary>
		/// 작업시작시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _workerNo
		/// </summary>
		public long WorkerNo { get; set; }
		/// <summary>
		/// 서버번호
		/// </summary>
		public short? ServerNo { get; set; }
		/// <summary>
		/// OdbcNpcWorkingType 와 연결됨.
		/// </summary>
		public byte WorkingType { get; set; }
		/// <summary>
		/// 남은 작업회수
		/// </summary>
		public int LeftCount { get; set; }
		/// <summary>
		/// 목적지 정보(_workingType에 따라서 가변적임)
		/// </summary>
		public long ToVariable { get; set; }
		/// <summary>
		/// 작업내역 정보(_workingType에 따라서 가변적임)
		/// </summary>
		public int WorkingVariable { get; set; }
		/// <summary>
		/// 작업내역 정보2(_workingType에 따라서 가변적임)
		/// </summary>
		public int WorkingVariable2 { get; set; }
		/// <summary>
		/// 목적지(=작업할 물건이 있는 곳)
		/// </summary>
		public int ToPlantKey { get; set; }
		/// <summary>
		/// 목적지가 동적 플랜트일경우 추가키
		/// </summary>
		public long ToPlantDynamicKey { get; set; }
		/// <summary>
		/// 할일(전출의 경우 키 지정없음)
		/// </summary>
		public int ExchangeKey { get; set; }
		/// <summary>
		/// 집에서 제작하는 경우 사용할 (설치된)주설비의 번호
		/// </summary>
		public long InstallationNo { get; set; }
		/// <summary>
		/// 생산 효율 레벨
		/// </summary>
		public short ProductivityLevel { get; set; }
		/// <summary>
		/// 운 생산 효율 레벨
		/// </summary>
		public short LuckProductivityLevel { get; set; }
		/// <summary>
		/// 개량할 아이템종류의 enchantLevel(_workingType에 따라서 가변적임)
		/// </summary>
		public byte EnchantLevel { get; set; }
		/// <summary>
		/// 개량할 아이템의 내구도
		/// </summary>
		public int Endurance { get; set; }
		/// <summary>
		/// 개량할 아이템의 최대 내구도
		/// </summary>
		public int MaxEndurance { get; set; }
		/// <summary>
		/// 일상태 변경시간
		/// </summary>
		public DateTime StateChangeTime { get; set; }
		/// <summary>
		/// 일의 상태
		/// </summary>
		public int WorkingState { get; set; }
	}
}
