namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 집이 기간 만료 후 남아있는 자판기 및 위탁판매용 아이템 임시 저장소(0408안씀)
	/// </summary>
	public partial class TblInstallationTempVirtualItemList
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 아이템키
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 강화레벨
		/// </summary>
		public byte EnchantLevel { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// 스택여부
		/// </summary>
		public bool IsStackable { get; set; }
		/// <summary>
		/// _townRegionKey
		/// </summary>
		public int TownRegionKey { get; set; }
	}
}
