namespace BlackDesert.TradeMarket.Db.LogContext
{
	/// <summary>
	/// Service 로그
	/// </summary>
	public partial class TblServiceLog
	{
		/// <summary>
		/// 로그 고유번호
		/// </summary>
		public long LogNo { get; set; }
		/// <summary>
		/// 로그 타입
		/// </summary>
		public short? OperationLogType { get; set; }
		/// <summary>
		/// 서버 번호
		/// </summary>
		public short? ServerNo { get; set; }
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저 ID
		/// </summary>
		public string? UserId { get; set; }
		/// <summary>
		/// 유저 고유 번호
		/// </summary>
		public long? UserNo { get; set; }
		/// <summary>
		/// 유저 IP
		/// </summary>
		public string? UserIp { get; set; }
		/// <summary>
		/// 참이면 운영자
		/// </summary>
		public bool IsUserGm { get; set; }
		/// <summary>
		/// 유저 플레이 시간
		/// </summary>
		public long? PlayMinuteOfUser { get; set; }
		/// <summary>
		/// 참이면 PC방
		/// </summary>
		public bool IsPcRoom { get; set; }
		/// <summary>
		/// 참이면 PC방 혜택
		/// </summary>
		public bool IsPcRoomPremium { get; set; }
		/// <summary>
		/// 참이면 PVP
		/// </summary>
		public bool IsPvP { get; set; }
		/// <summary>
		/// guest 계정 여부
		/// </summary>
		public bool? IsGuestAccount { get; set; }
		/// <summary>
		/// 15세 이용가
		/// </summary>
		public byte? GameAgeGradeType { get; set; }
		/// <summary>
		/// 운영 로그 내용
		/// </summary>
		public string? ServiceString { get; set; }
		/// <summary>
		/// 로그 이유
		/// </summary>
		public long SymNoReason { get; set; }
		/// <summary>
		/// param1
		/// </summary>
		public long? ServiceParam1 { get; set; }
		/// <summary>
		/// param2
		/// </summary>
		public long? ServiceParam2 { get; set; }
		/// <summary>
		/// param3
		/// </summary>
		public long? ServiceParam3 { get; set; }
	}
}
