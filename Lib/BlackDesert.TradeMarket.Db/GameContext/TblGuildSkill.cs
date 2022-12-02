namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드 스킬 정보
	/// </summary>
	public partial class TblGuildSkill
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 습득한 길드 스킬 번호
		/// </summary>
		public int SkillNo { get; set; }
		/// <summary>
		/// 습득한 길드 스킬 레벨
		/// </summary>
		public int SkillLevel { get; set; }
		/// <summary>
		/// 스킬을 활성한 시킨 유저 정보
		/// </summary>
		public long UserNo { get; set; }
	}
}
