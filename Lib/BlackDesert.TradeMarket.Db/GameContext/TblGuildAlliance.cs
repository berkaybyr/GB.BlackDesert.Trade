namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 길드연합
	/// </summary>
	public partial class TblGuildAlliance
	{
		/// <summary>
		/// 등록일(길드연합장의 등록일)
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 연합길드번호
		/// </summary>
		public long ChairGuildNo { get; set; }
		/// <summary>
		/// 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 길드인원 제한
		/// </summary>
		public int LimitMemberCount { get; set; }
		/// <summary>
		/// 길드인원 세금 상수
		/// </summary>
		public int TaxRate { get; set; }
	}
}
