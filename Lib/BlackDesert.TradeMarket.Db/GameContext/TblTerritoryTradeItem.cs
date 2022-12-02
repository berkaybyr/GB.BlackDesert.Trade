namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 영지 무역, 납품 아이템 테이블
	/// </summary>
	public partial class TblTerritoryTradeItem
	{
		/// <summary>
		/// 영지 번호
		/// </summary>
		public long TerritoryKey { get; set; }
		/// <summary>
		/// 영지 아이템 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 영지 무역 gc::ItemMainGroupKey 
		/// </summary>
		public int? TradeItemMainGroupKey { get; set; }
		/// <summary>
		/// 영지 납품 gc::ItemMainGroupKey 
		/// </summary>
		public int? SupplyItemMainGroupKey { get; set; }
	}
}
