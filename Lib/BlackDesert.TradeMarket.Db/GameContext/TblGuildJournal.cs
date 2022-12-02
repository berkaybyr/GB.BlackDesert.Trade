namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 나의 일지 시스템
	/// </summary>
	public partial class TblGuildJournal
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 날짜키
		/// </summary>
		public long DateKey { get; set; }
		/// <summary>
		/// 소유자타입(0 캐릭터,1길드)
		/// </summary>
		public short OwnerType { get; set; }
		/// <summary>
		/// 길드 번호
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 길드 이름
		/// </summary>
		public string? GuildName { get; set; }
		/// <summary>
		/// owner의 GuildMemberGrade
		/// </summary>
		public byte? OwnerMemberGrade { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long? OwnerCharacterNo { get; set; }
		/// <summary>
		/// 캐릭터 이름
		/// </summary>
		public string? OwnerName { get; set; }
		/// <summary>
		/// UserNo
		/// </summary>
		public long? OwnerUserNo { get; set; }
		/// <summary>
		/// 가문명
		/// </summary>
		public string? OwnerNickname { get; set; }
		/// <summary>
		/// 길마 유저번호
		/// </summary>
		public long? OwnerMasterUserNo { get; set; }
		/// <summary>
		/// 길마 가문명
		/// </summary>
		public string? OwnerMasterUserNickname { get; set; }
		/// <summary>
		/// target의 길드 번호
		/// </summary>
		public long? TargetGuildNo { get; set; }
		/// <summary>
		/// target의 길드 이름
		/// </summary>
		public string? TargetGuildName { get; set; }
		/// <summary>
		/// target의 GuildMemberGrade
		/// </summary>
		public byte? TargetMemberGrade { get; set; }
		/// <summary>
		/// target의 캐릭터 번호
		/// </summary>
		public long? TargetCharacterNo { get; set; }
		/// <summary>
		/// target의 캐릭터 이름
		/// </summary>
		public string? TargetCharacterName { get; set; }
		/// <summary>
		/// targer의 UserNo
		/// </summary>
		public long? TargetUserNo { get; set; }
		/// <summary>
		/// targer의 가문명
		/// </summary>
		public string? TargetUserNickname { get; set; }
		/// <summary>
		/// 길마 유저번호
		/// </summary>
		public long? TargetMasterUserNo { get; set; }
		/// <summary>
		/// 길마 가문명
		/// </summary>
		public string? TargetMasterUserNickname { get; set; }
		/// <summary>
		/// 일지타입(JournalType-0칭호획득, 1 강화성공...)
		/// </summary>
		public short JournalType { get; set; }
		/// <summary>
		/// 위치값
		/// </summary>
		public long? PositionX { get; set; }
		/// <summary>
		/// 위치값
		/// </summary>
		public long? PositionY { get; set; }
		/// <summary>
		/// 위치값
		/// </summary>
		public long? PositionZ { get; set; }
		/// <summary>
		/// 인자1
		/// </summary>
		public long ParameterNo1 { get; set; }
		/// <summary>
		/// 인자2
		/// </summary>
		public int ParameterNo2 { get; set; }
		/// <summary>
		/// 문자열
		/// </summary>
		public string? ParameterString { get; set; }
		/// <summary>
		/// 서버 번호
		/// </summary>
		public short? ServerNo { get; set; }
	}
}
