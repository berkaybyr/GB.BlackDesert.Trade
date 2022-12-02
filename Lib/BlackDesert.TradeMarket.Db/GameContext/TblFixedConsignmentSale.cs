namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 위탁 판매 정보
	/// </summary>
	public partial class TblFixedConsignmentSale
	{
		/// <summary>
		/// 위탁판매 고유번호
		/// </summary>
		public long ConsignmentNo { get; set; }
		/// <summary>
		/// 해당지역 자판기_위탁판매기 번호
		/// </summary>
		public int VendorCharacterKey { get; set; }
		/// <summary>
		/// 아이템번호
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// 아이템키
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 스택여부
		/// </summary>
		public bool IsStackable { get; set; }
		/// <summary>
		/// 소유자캐릭터번호
		/// </summary>
		public long OwnerCharacterNo { get; set; }
		/// <summary>
		/// 등록비
		/// </summary>
		public long RegisterMoney { get; set; }
		/// <summary>
		/// 개당 가격
		/// </summary>
		public long PricePerOne { get; set; }
		/// <summary>
		/// 판매후 모아진 돈
		/// </summary>
		public long GatherMoney { get; set; }
		/// <summary>
		/// 수수료
		/// </summary>
		public double CommissionRate { get; set; }
		/// <summary>
		/// 판매종료일
		/// </summary>
		public long ExpireTime { get; set; }
		/// <summary>
		/// 아이템이 모두 팔리면 1
		/// </summary>
		public bool SaleEnd { get; set; }
	}
}
