namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 탐험 포인트(지역별 지지도)
	/// </summary>
	public partial class TblSupportPoint
	{
		/// <summary>
		/// 유저 고유번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		public long TerritoryKey { get; set; }
		/// <summary>
		/// 남은 포인트
		/// </summary>
		public int RemainedPoint { get; set; }
		/// <summary>
		/// 총 획득 포인트
		/// </summary>
		public int AquiredPoint { get; set; }
		/// <summary>
		/// 경험치
		/// </summary>
		public long Experience { get; set; }
	}
}
