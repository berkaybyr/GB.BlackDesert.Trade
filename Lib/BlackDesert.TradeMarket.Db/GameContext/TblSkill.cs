namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 스킬 정보
	/// </summary>
	public partial class TblSkill
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 스킬번호
		/// </summary>
		public int SkillNo { get; set; }
		/// <summary>
		/// 스킬 배우는 방법 타입
		/// </summary>
		public byte SkillLearningType { get; set; }
		/// <summary>
		/// 스킬 포인트타입(전투,생산)
		/// </summary>
		public byte SkillPointType { get; set; }
		/// <summary>
		/// _skillLevel
		/// </summary>
		public int SkillLevel { get; set; }
		/// <summary>
		/// _isPlayer
		/// </summary>
		public bool IsPlayer { get; set; }
	}
}
