namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드멤버정보
	/// </summary>
	public partial class TblGuildMember
	{
		/// <summary>
		/// 길드가입일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 사용자 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 길드원 등급
		/// </summary>
		public byte Grade { get; set; }
		/// <summary>
		/// 멤버가 기여한 길드 성향치
		/// </summary>
		public int ContributedTendency { get; set; }
		/// <summary>
		/// 다음 계약이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)
		/// </summary>
		public DateTime? ContractableDate { get; set; }
		/// <summary>
		/// 계약기간 만료(길드가 동아리 등급이면 NULL일 수 있다.)
		/// </summary>
		public DateTime? ContractedExpiration { get; set; }
		/// <summary>
		/// 수당(실버)	( 길드가 동아리 등급이면 NULL일 수 있다.)
		/// </summary>
		public long? Benefit { get; set; }
		/// <summary>
		///  위약금		(길드가 동아리 등급이면 NULL일 수 있다.)
		/// </summary>
		public long? Penalty { get; set; }
		/// <summary>
		/// 수당(일당) 수금이 가능한지? 1이면 가능, NULL 이거나, 0이면 안됨
		/// </summary>
		public bool? IsCollectable { get; set; }
		/// <summary>
		/// 총 활동 점수
		/// </summary>
		public int TotalActivity { get; set; }
		/// <summary>
		/// 사용 가능한 활동 점수(고용계약시 수당 갱신에 사용)
		/// </summary>
		public int UsableActivity { get; set; }
		/// <summary>
		/// 계약한 일 수
		/// </summary>
		public int? ContractedDay { get; set; }
		/// <summary>
		/// 보호 여부? 1이면 보호, NULL 이거나, 0이면 비보호
		/// </summary>
		public bool? IsProtectable { get; set; }
		/// <summary>
		/// 다음 보호 여부 변경이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)
		/// </summary>
		public DateTime? ProtectableDate { get; set; }
		/// <summary>
		/// 음성 채팅 말하기 on/off
		/// </summary>
		public bool IsVoiceChatSpeak { get; set; }
		/// <summary>
		/// 음성 채팅 듣기 on/off
		/// </summary>
		public bool IsVoiceChatListen { get; set; }
		/// <summary>
		/// 길드 자금 사용 한도
		/// </summary>
		public long MyPriceLimit { get; set; }
		/// <summary>
		/// 길드 자금 사용 한도 검사 유/무
		/// </summary>
		public bool? IsPriceLimit { get; set; }
		/// <summary>
		/// 최근 길드인센티브 지급등급
		/// </summary>
		public int IncentiveGrade { get; set; }
		/// <summary>
		/// 공성전에 참여 가능한 전투원
		/// </summary>
		public byte SiegeCombatant { get; set; }
		/// <summary>
		/// 공성전에 참여 가능한 전투원
		/// </summary>
		public bool IsSiegeParticipant { get; set; }
		/// <summary>
		/// 길드 상여금
		/// </summary>
		public long Bonus { get; set; }
		/// <summary>
		/// 휴가중인지
		/// </summary>
		public bool IsVacation { get; set; }
		/// <summary>
		/// 공성전 훈장 보상.
		/// </summary>
		public int SiegeMedalCount { get; set; }
		/// <summary>
		/// 공성전 1등 보상.
		/// </summary>
		public int SiegeTopItemKey { get; set; }
		public double SiegeMercenaryCost { get; set; }
		public long UserCharacterNoForCost { get; set; }
		/// <summary>
		/// 공성전 보상 지급 시간.
		/// </summary>
		public DateTime? LastSiegeRewardDate { get; set; }
		public int SiegeItemKey { get; set; }
		public int Top5PercentsiegeItemCount { get; set; }
		public int Top5PercentsiegeItemKey { get; set; }
	}
}
