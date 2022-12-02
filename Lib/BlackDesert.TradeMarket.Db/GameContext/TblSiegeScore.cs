namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드공성전적
	/// </summary>
	public partial class TblSiegeScore
	{
		/// <summary>
		/// 공성 회차
		/// </summary>
		public int SiegeScoreNo { get; set; }
		/// <summary>
		/// 공성 시작 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 공성 전적 업데이트 시간
		/// </summary>
		public DateTime? UpdateDate { get; set; }
		/// <summary>
		/// 참여 길드 번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 참여 길드 이름
		/// </summary>
		public string GuildName { get; set; } = null!;
		/// <summary>
		/// 참여 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 가문명
		/// </summary>
		public string UserNickname { get; set; } = null!;
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long? CharacterNo { get; set; }
		/// <summary>
		/// 캐릭터명
		/// </summary>
		public string? CharacterName { get; set; }
		/// <summary>
		/// 해당 공성의 영지키
		/// </summary>
		public int TerritoryKey { get; set; }
		/// <summary>
		/// 해당 공성의 지역키
		/// </summary>
		public int RegionKey { get; set; }
		/// <summary>
		/// 해당 공성의 종류
		/// </summary>
		public bool IsVillageSiege { get; set; }
		/// <summary>
		/// 사망 횟수
		/// </summary>
		public int ScoreType0 { get; set; }
		/// <summary>
		/// 지휘소 파괴 횟수
		/// </summary>
		public int ScoreType1 { get; set; }
		/// <summary>
		/// 성채 파괴 횟수
		/// </summary>
		public int ScoreType2 { get; set; }
		/// <summary>
		/// 군주 (연합 길드장) 죽인 횟수
		/// </summary>
		public int ScoreType3 { get; set; }
		/// <summary>
		/// 대장 처치 횟수
		/// </summary>
		public int ScoreType4 { get; set; }
		/// <summary>
		/// 성문 파괴 횟수
		/// </summary>
		public int ScoreType5 { get; set; }
		/// <summary>
		/// 부대장 처치 횟수
		/// </summary>
		public int ScoreType6 { get; set; }
		/// <summary>
		/// 길드처치 횟수
		/// </summary>
		public int ScoreType7 { get; set; }
		/// <summary>
		/// 도움 횟수
		/// </summary>
		public int ScoreType8 { get; set; }
		/// <summary>
		/// 탑승물 처치 횟수
		/// </summary>
		public int ScoreType9 { get; set; }
		/// <summary>
		/// 배치물 파괴 횟수
		/// </summary>
		public int ScoreType10 { get; set; }
		/// <summary>
		/// 공성병기로 사람을 죽인 횟수
		/// </summary>
		public int ScoreType11 { get; set; }
	}
}
