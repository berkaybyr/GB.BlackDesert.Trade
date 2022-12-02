namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드하우스 대량제작
	/// </summary>
	public partial class TblGuildHouseLargeCraftDailyCount
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
		/// 오늘 수행한대량생산 수
		/// </summary>
		public long CompleteCount { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
