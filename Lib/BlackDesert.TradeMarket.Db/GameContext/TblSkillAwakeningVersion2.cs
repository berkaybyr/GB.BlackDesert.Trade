namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 스킬 각성 정보 ( 리뉴얼 )
	/// </summary>
	public partial class TblSkillAwakeningVersion2
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
		/// _awakeningBitFlag
		/// </summary>
		public int AwakeningBitFlag { get; set; }
	}
}
