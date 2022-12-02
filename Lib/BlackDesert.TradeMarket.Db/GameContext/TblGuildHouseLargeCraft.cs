namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드하우스 대량제작
	/// </summary>
	public partial class TblGuildHouseLargeCraft
	{
		/// <summary>
		/// 대량생산의 주체번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 집의 레시피타입키 / 0은 용도없음
		/// </summary>
		public int ReceipeKey { get; set; }
		/// <summary>
		/// 대량생산 exchange키
		/// </summary>
		public int LargeExchangeKey { get; set; }
		/// <summary>
		/// 대량생산 남은 수 0
		/// </summary>
		public long CompletePoint0 { get; set; }
		/// <summary>
		/// 대량생산 남은 수 1
		/// </summary>
		public long CompletePoint1 { get; set; }
		/// <summary>
		/// 대량생산 남은 수 2
		/// </summary>
		public long CompletePoint2 { get; set; }
		/// <summary>
		/// 대량생산 남은 수 3
		/// </summary>
		public long CompletePoint3 { get; set; }
		/// <summary>
		/// 대량생산 남은 수 4
		/// </summary>
		public long CompletePoint4 { get; set; }
		/// <summary>
		/// 대량생산 남은 수 5
		/// </summary>
		public long CompletePoint5 { get; set; }
	}
}
