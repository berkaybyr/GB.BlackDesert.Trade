namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아이템&amp;돈 저장소
	/// </summary>
	public partial class TblItemRepository
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 참인 경우에만 정상적인 아이템임
		/// </summary>
		public bool? IsValid { get; set; }
		/// <summary>
		/// 아이템 고유번호
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// _itemKey
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 최초로 만들어진/생산되어진 지역번호
		/// </summary>
		public int ProductionRegionKey { get; set; }
		/// <summary>
		/// 유통기한(NULL이면 무기한임)
		/// </summary>
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// _enchantLevel
		/// </summary>
		public byte EnchantLevel { get; set; }
		/// <summary>
		/// 참이면 귀속된 것임
		/// </summary>
		public bool IsVested { get; set; }
		/// <summary>
		/// 참이면 압류임
		/// </summary>
		public bool IsSeized { get; set; }
		/// <summary>
		/// 참이면 각인된 것임
		/// </summary>
		public bool? IsSealed { get; set; }
		/// <summary>
		/// 구매가격(무역아이템/경매 에서 의미가 있음)
		/// </summary>
		public long BuyingPrice { get; set; }
		/// <summary>
		/// 아이템위치
		/// </summary>
		public byte ItemWhereType { get; set; }
		/// <summary>
		/// _itemWhereType에 따라 의미 다름
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// _itemWhereType에 따라 의미 다름
		/// </summary>
		public long VariousNo { get; set; }
		/// <summary>
		/// _variableDate
		/// </summary>
		public DateTime VariableDate { get; set; }
		/// <summary>
		/// _pushedItemKey0
		/// </summary>
		public int? PushedItemKey0 { get; set; }
		/// <summary>
		/// _pushedItemKey1
		/// </summary>
		public int? PushedItemKey1 { get; set; }
		/// <summary>
		/// _pushedItemKey2
		/// </summary>
		public int? PushedItemKey2 { get; set; }
		/// <summary>
		/// _pushedItemKey3
		/// </summary>
		public int? PushedItemKey3 { get; set; }
		/// <summary>
		/// _pushedItemKey4
		/// </summary>
		public int? PushedItemKey4 { get; set; }
		/// <summary>
		/// _pushedItemKey5
		/// </summary>
		public int? PushedItemKey5 { get; set; }
		/// <summary>
		/// 아이템 개수
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// 내구도
		/// </summary>
		public int Endurance { get; set; }
		/// <summary>
		/// 최대 내구도
		/// </summary>
		public int MaxEndurance { get; set; }
		public byte[]? DyeingList { get; set; }
		/// <summary>
		/// true 면 기간제 염색이 적용된 아이템임
		/// </summary>
		public bool IsExpirationDyeing { get; set; }
	}
}
