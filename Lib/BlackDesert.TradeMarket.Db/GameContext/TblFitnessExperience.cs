namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 건강 경험치
	/// </summary>
	public partial class TblFitnessExperience
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 0 호흡,1 힘,2 건강
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 경험치
		/// </summary>
		public long Experience { get; set; }
	}
}
