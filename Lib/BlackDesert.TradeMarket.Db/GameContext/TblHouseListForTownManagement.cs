namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 마을 관리 유저가 소유한 집 목록
	/// </summary>
	public partial class TblHouseListForTownManagement
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// _houseKey
		/// </summary>
		public int HouseKey { get; set; }
		/// <summary>
		/// 0은 용도없음
		/// </summary>
		public int UseType { get; set; }
		/// <summary>
		/// 이전레벨
		/// </summary>
		public int PrevLevel { get; set; }
		/// <summary>
		/// 현재레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 돌려받을 탐험포인트 지역키
		/// </summary>
		public long TerritoryKey { get; set; }
		/// <summary>
		/// 돌려받을 탐험포인트
		/// </summary>
		public int ReturnExplorePoint { get; set; }
		/// <summary>
		/// 사용 가능한 시간(용도 변경시 세팅)
		/// </summary>
		public DateTime UsableTime { get; set; }
	}
}
