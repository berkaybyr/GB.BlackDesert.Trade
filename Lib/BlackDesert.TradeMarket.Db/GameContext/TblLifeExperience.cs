namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 생활 숙련도 정보
	/// </summary>
	public partial class TblLifeExperience
	{
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		public long UserNo { get; set; }
		/// <summary>
		/// 타입
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 숙련도
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 경험치
		/// </summary>
		public long Experience { get; set; }
	}
}
