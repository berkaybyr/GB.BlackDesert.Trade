namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 자판기 정보
	/// </summary>
	public partial class TblFixedVendingMachine
	{
		/// <summary>
		/// 해당지역 자판기_위탁판매기 번호
		/// </summary>
		public int VendorCharacterKey { get; set; }
		/// <summary>
		/// 자판기 내부 물건 구분
		/// </summary>
		public short VendingIndex { get; set; }
		/// <summary>
		/// 아이템키
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 강화레벨
		/// </summary>
		public byte EnchantLevel { get; set; }
		/// <summary>
		/// 스택여부
		/// </summary>
		public bool IsStackable { get; set; }
		/// <summary>
		/// 갯수
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// 구매가격
		/// </summary>
		public long BuyFromUserPrice { get; set; }
		/// <summary>
		/// 판매가격
		/// </summary>
		public long SellToUserPrice { get; set; }
		/// <summary>
		/// 최대 스택갯수
		/// </summary>
		public long MaxStackCount { get; set; }
	}
}
