namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 민병대 정보
	/// </summary>
	public partial class TblMilitiaMember
	{
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public int TerritoryKey { get; set; }
		/// <summary>
		/// 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long? CharacterNo { get; set; }
		/// <summary>
		/// 길드 번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 공격 팀 신청
		/// </summary>
		public bool? IsAttackTeam { get; set; }
		/// <summary>
		/// 신청 상태
		/// </summary>
		public byte State { get; set; }
		/// <summary>
		/// 공방 합
		/// </summary>
		public int AdSummary { get; set; }
	}
}
