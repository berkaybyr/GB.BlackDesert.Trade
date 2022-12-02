namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 하우징 하우스홀드 기본 테이블
	/// </summary>
	public partial class TblHouseholdSpec
	{
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _householdNo
		/// </summary>
		public long HouseholdNo { get; set; }
		/// <summary>
		/// 텐트나 고정집에 대응하는 캐릭터키
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// household의 타입 - 0개인텐트,1고정집,2하우징설치물,3장애물,4공성텐트,5마을의 여관방,6성채 텐트7함정,8촌장텐트
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 캐릭을 소유한 사용자번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 소유자 사용자 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 집/텐트가 설치된 구역의 레지온키
		/// </summary>
		public int TownRegionKey { get; set; }
		/// <summary>
		/// 현재는 만료기간이 Auction 에서 하고 있음
		/// </summary>
		public DateTime? Expiration { get; set; }
	}
}
