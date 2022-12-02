namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 토벌결과아이템
	/// </summary>
	public partial class TblExpeditionResultItem
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 아이템키
		/// </summary>
		public int ItemEnchantKey { get; set; }
		/// <summary>
		/// 아이템 갯수
		/// </summary>
		public long ItemCount { get; set; }
		/// <summary>
		/// 등록된 시간
		/// </summary>
		public DateTime RegisterDateDate { get; set; }
	}
}
