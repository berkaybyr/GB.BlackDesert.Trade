namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 용병 리스트
	/// </summary>
	public partial class TblRecordGuildVolunteerScore
	{
		/// <summary>
		/// 용병 길드 넘버
		/// </summary>
		public long VolunteerGuilNo { get; set; }
		/// <summary>
		/// 용병 길드 이름
		/// </summary>
		public string VolunteerguildName { get; set; } = null!;
		/// <summary>
		/// 원래 길드 넘버
		/// </summary>
		public long? OriginalGuilNo { get; set; }
		/// <summary>
		/// 원래 길드 이름
		/// </summary>
		public string? OriginalGuildName { get; set; }
		/// <summary>
		/// 유저 넘버
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 유저 가문명
		/// </summary>
		public string UserNickname { get; set; } = null!;
		/// <summary>
		/// 캐릭터 넘버
		/// </summary>
		public long? CharacterNo { get; set; }
		/// <summary>
		/// 캐릭터 넘버
		/// </summary>
		public string? CharacterName { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 거점/점령전 요일
		/// </summary>
		public int? SiegeScoreNo { get; set; }
		/// <summary>
		/// 거점 리전 키
		/// </summary>
		public int? RegionKey { get; set; }
		/// <summary>
		/// 거점전 인지
		/// </summary>
		public bool? IsVillageSiege { get; set; }
		/// <summary>
		/// 용병 성공 했는지
		/// </summary>
		public bool MissionComplete { get; set; }
		/// <summary>
		/// 죽인 횟수
		/// </summary>
		public int KillCount { get; set; }
		/// <summary>
		/// 사망 횟수
		/// </summary>
		public int DeathCount { get; set; }
	}
}
