namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 세금 납입 시간 기록용
	/// </summary>
	public partial class TblSiegeTaxTime
	{
		/// <summary>
		/// 지급 시간
		/// </summary>
		public DateTime LastPayTime { get; set; }
	}
}
