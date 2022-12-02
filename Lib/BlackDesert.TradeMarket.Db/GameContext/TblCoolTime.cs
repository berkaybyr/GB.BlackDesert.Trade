namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 쿨타임을 저장하기 위한 테이블
	/// </summary>
	public partial class TblCoolTime
	{
		/// <summary>
		///  pc 스킬의 쿨타임인지 길드 스킬의 쿨타임인지 구분하는 타입 ( 0 = PC, 1= guild)
		/// </summary>
		public byte SkillType { get; set; }
		/// <summary>
		/// skillType 에 따라 캐릭터No, 길드 No로 사용된다.
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 재사용 대기중인 스킬의 넘버
		/// </summary>
		public int SkillNo { get; set; }
		/// <summary>
		/// 재사용 대기중인 스킬의 레벨
		/// </summary>
		public int SkillLevel { get; set; }
		/// <summary>
		/// 재사용그룹의 넘버
		/// </summary>
		public int ReuseGroup { get; set; }
		public bool IsExpiredTime { get; set; }
		public long RemainOrExpiredtime { get; set; }
	}
}
