namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 위탁 판매 정보
	/// </summary>
	public partial class TblConsignmentSale
	{
		/// <summary>
		/// _consignmentNo
		/// </summary>
		public long ConsignmentNo { get; set; }
		/// <summary>
		/// _householdNo
		/// </summary>
		public long HouseholdNo { get; set; }
		/// <summary>
		/// _installationNo
		/// </summary>
		public long InstallationNo { get; set; }
		/// <summary>
		/// _itemNo
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// _itemKey
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// _isStackable
		/// </summary>
		public bool IsStackable { get; set; }
		/// <summary>
		/// _ownerCharacterNo
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
		/// 판매후 모아진 돈(수수료 뺀 금액)
		/// </summary>
		public long GatherMoney { get; set; }
		/// <summary>
		/// 수수료(등록시 저장)
		/// </summary>
		public double CommissionRate { get; set; }
		/// <summary>
		/// 판매 종료일
		/// </summary>
		public long ExpireTime { get; set; }
		/// <summary>
		/// 아이템이 모두팔리면 1
		/// </summary>
		public bool SaleEnd { get; set; }
	}
}
