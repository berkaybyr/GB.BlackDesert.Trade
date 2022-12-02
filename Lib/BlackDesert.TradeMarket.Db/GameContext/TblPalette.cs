namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 팔레트
	/// </summary>
	public partial class TblPalette
	{
		/// <summary>
		/// 소유자번호
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 아이템키
		/// </summary>
		public int ItemKey { get; set; }
		public byte PaletteType { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		public long Count { get; set; }
	}
}
