namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유저정보
	/// </summary>
	public partial class TblUserInformation
	{
		/// <summary>
		/// 생성일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 참인 경우에만 선택할 수 있는 사용자임
		/// </summary>
		public bool? IsValid { get; set; }
		/// <summary>
		/// _userNo
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// _userId
		/// </summary>
		public string UserId { get; set; } = null!;
		/// <summary>
		/// _userNickname
		/// </summary>
		public string? UserNickname { get; set; }
		/// <summary>
		/// 인증Key
		/// </summary>
		public int AuthenticKey { get; set; }
		/// <summary>
		/// 인증유통기한
		/// </summary>
		public DateTime AuthenticExpiration { get; set; }
		public int WebAuthenticKey { get; set; }
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
		/// 최근접속IP
		/// </summary>
		public string LastIp { get; set; } = null!;
		/// <summary>
		/// 접속중인 월드번호.=&gt;접속중이 아니면 음수임
		/// </summary>
		public short LastServerNo { get; set; }
		/// <summary>
		/// 비밀번호 틀린 횟수
		/// </summary>
		public byte FailPasswordCount { get; set; }
		/// <summary>
		/// 퍼블리셔 토큰 정보
		/// </summary>
		public string? PublisherCryptToken { get; set; }
		/// <summary>
		/// 유저 채널링 정보
		/// </summary>
		public byte MembershipType { get; set; }
		/// <summary>
		/// 스피드서버 접속 가능 여부
		/// </summary>
		public byte IsAdmissionToSpeedServer { get; set; }
		/// <summary>
		/// 피씨방 여부
		/// </summary>
		public bool IsPcRoom { get; set; }
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// 게스트 패스
		/// </summary>
		public bool IsGuestAccount { get; set; }
		/// <summary>
		/// 스피드서버 접속 가능 기간
		/// </summary>
		public DateTime SpeedServerExpiration { get; set; }
		/// <summary>
		/// 계정 만료 시간
		/// </summary>
		public DateTime? AccountExpirationDate { get; set; }
		/// <summary>
		/// 하드웨어와 드라이버 정보
		/// </summary>
		public string? SurveyHwandSw { get; set; }
		/// <summary>
		/// 밸런스 채널에 접속 가능한가
		/// </summary>
		public bool? IsAccessBlanceChannel { get; set; }
		/// <summary>
		/// 프리미엄 채널 입장 가능여부
		/// </summary>
		public bool IsPremiumChannelPermission { get; set; }
		/// <summary>
		/// 사전생성 기간에도 접속 유무
		/// </summary>
		public bool IsIgnoreCheckCustomizeOnly { get; set; }
		/// <summary>
		/// 재접 인증Key
		/// </summary>
		public int PreAuthenticKey { get; set; }
		/// <summary>
		/// 성인 채널에 접속 한 계정인지
		/// </summary>
		public bool? IsAdultWorldUser { get; set; }
		/// <summary>
		/// 셧다운 시간
		/// </summary>
		public DateTime? ShutDownTime { get; set; }
		public bool IsOtp { get; set; }
		public string? AtField { get; set; }
		public bool IsCompleteTesterSubmit { get; set; }
		public short? LastWorldNo { get; set; }
		public short? ServiceType { get; set; }
		public byte[]? LastMacAddress { get; set; }
		public int AllCharacterTotalLevel { get; set; }
		public string? Email { get; set; }
		public string Username { get; set; } = null!;
		public string RealPassword { get; set; } = null!;
		public long Balance { get; set; }
		public bool IsEmailConfirmed { get; set; }
		public string? Fullname { get; set; }
		public bool IsAppliedNickNameChange { get; set; }
		/// <summary>
		/// 2차 비밀 번호
		/// </summary>
		public byte[]? Password { get; set; }
		/// <summary>
		/// 결제 비밀 번호
		/// </summary>
		public byte[]? PaymentPassword { get; set; }
		public string? PlayToken { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? TokenExpireDate { get; set; }
	}
}
