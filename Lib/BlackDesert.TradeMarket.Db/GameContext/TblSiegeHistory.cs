namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 공성&amp;마을 정보
	/// </summary>
	public partial class TblSiegeHistory
	{
		/// <summary>
		/// 최초 등록시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 갱신된 시간
		/// </summary>
		public DateTime? UpdateDate { get; set; }
		/// <summary>
		/// 공성 날짜 키
		/// </summary>
		public int SiegeHistoryDate { get; set; }
		/// <summary>
		/// 공성 종류
		/// </summary>
		public bool IsVillageSiege { get; set; }
		/// <summary>
		/// _regionKey
		/// </summary>
		public int RegionKey { get; set; }
		/// <summary>
		/// 점령일시(주인이 없다면 해방일시)
		/// </summary>
		public DateTime OccupyingDate { get; set; }
		/// <summary>
		/// 주인이 없으면 0
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 점령 길드명
		/// </summary>
		public string GuildName { get; set; } = null!;
	}
}
