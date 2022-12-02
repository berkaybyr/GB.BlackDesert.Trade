namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드가공일일횟수
	/// </summary>
	public partial class TblGuildManufactureDailyCount
	{
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 가공아이템완료갯수
		/// </summary>
		public long CompleteCount { get; set; }
		/// <summary>
		/// 마지막 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 가공아이템
		/// </summary>
		public int ProductItemKey { get; set; }
	}
}
