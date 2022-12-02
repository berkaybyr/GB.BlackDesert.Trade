namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 백과사전(어류도감)
	/// </summary>
	public partial class TblEncyclopedium
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 어종키 (DataSheet_Encyclopedia$Encyclopedia_Table)
		/// </summary>
		public int Key { get; set; }
		/// <summary>
		/// 잡은 수량
		/// </summary>
		public int Count { get; set; }
		/// <summary>
		/// 최대크기
		/// </summary>
		public int Value { get; set; }
	}
}
