namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 부대
	/// </summary>
	public partial class TblExpeditionaryUnit
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 유닛 번호
		/// </summary>
		public long UnitNo { get; set; }
		/// <summary>
		/// 유닛키
		/// </summary>
		public int UnitKey { get; set; }
		public byte UnitGrade { get; set; }
		/// <summary>
		/// 부대레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 부대 경험치
		/// </summary>
		public long Experience { get; set; }
		public int EnergyPoint { get; set; }
	}
}
