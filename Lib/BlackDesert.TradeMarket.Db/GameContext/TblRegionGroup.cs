namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 영역별 정보
	/// </summary>
	public partial class TblRegionGroup
	{
		/// <summary>
		/// 마지막 수정일시
		/// </summary>
		public DateTime LastUpdateDate { get; set; }
		/// <summary>
		/// _regionGroupKey
		/// </summary>
		public int RegionGroupKey { get; set; }
		/// <summary>
		/// 농산물 생산력
		/// </summary>
		public int CorpProductivity { get; set; }
		/// <summary>
		/// 낚시 생산력
		/// </summary>
		public int FishingProductivity { get; set; }
		/// <summary>
		/// 충성도
		/// </summary>
		public int Loyalty { get; set; }
	}
}
