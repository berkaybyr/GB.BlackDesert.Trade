namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 세금정보
	/// </summary>
	public partial class TblTax
	{
		/// <summary>
		/// 점령일시
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _regionKey
		/// </summary>
		public int RegionKey { get; set; }
		/// <summary>
		/// _taxType
		/// </summary>
		public byte TaxType { get; set; }
		/// <summary>
		/// 현재 세율
		/// </summary>
		public int TaxRate { get; set; }
		/// <summary>
		/// 지방세(해당지역의 세금합)
		/// </summary>
		public long ProducedAmount { get; set; }
		/// <summary>
		/// 주민세(소속지역주민들의 세금합)
		/// </summary>
		public long AffiliatedAmount { get; set; }
	}
}
