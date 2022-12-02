namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 창고 확장 슬롯 수 저장
	/// </summary>
	public partial class TblWarehouseSlotCount
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 지역키
		/// </summary>
		public int RegionKey { get; set; }
		/// <summary>
		/// 슬롯 추가 갯수(아이템 사용)
		/// </summary>
		public byte SlotCount { get; set; }
	}
}
