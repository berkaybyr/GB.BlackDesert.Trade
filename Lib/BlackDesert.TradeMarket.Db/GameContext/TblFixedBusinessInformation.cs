namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 자판기_위탁판매
	/// </summary>
	public partial class TblFixedBusinessInformation
	{
		/// <summary>
		/// 주인
		/// </summary>
		public long OwnerUserNo { get; set; }
		/// <summary>
		/// 해당지역 자판기_위탁판매기 번호
		/// </summary>
		public int VendorCharacterKey { get; set; }
		/// <summary>
		/// 기간이 만료되어 아이템돌려줄때 사용
		/// </summary>
		public int TownRegionKey { get; set; }
		/// <summary>
		/// 0자동판매1위탁판매
		/// </summary>
		public int BusinessType { get; set; }
		/// <summary>
		/// 판매기간(위탁판매시)
		/// </summary>
		public long SaleTime { get; set; }
		/// <summary>
		/// 판매수수료(위탁판매시)
		/// </summary>
		public double CommissionRate { get; set; }
		/// <summary>
		/// 최소등록비(위탁판매시)
		/// </summary>
		public long MinRegisterMoney { get; set; }
		/// <summary>
		/// 보유금액
		/// </summary>
		public long HoldingMoney { get; set; }
		/// <summary>
		/// 액티브여부
		/// </summary>
		public bool IsActive { get; set; }
	}
}
