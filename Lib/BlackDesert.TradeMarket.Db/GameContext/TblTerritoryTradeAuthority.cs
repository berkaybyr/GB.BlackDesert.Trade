namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 영지 무역(황실무역) 권한 테이블
	/// </summary>
	public partial class TblTerritoryTradeAuthority
	{
		/// <summary>
		/// 유져 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 영지 번호
		/// </summary>
		public long TerritoryKey { get; set; }
	}
}
