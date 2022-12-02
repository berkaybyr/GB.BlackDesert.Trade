namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 범용 저장소
	/// </summary>
	public partial class TblGeneralRepository
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 타입별로 아래 분류
		/// </summary>
		public long Type { get; set; }
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long MainKey { get; set; }
		/// <summary>
		/// WayPoint 또는 캐릭터키
		/// </summary>
		public long SubKey { get; set; }
		/// <summary>
		/// 탐험lv 또는 친밀도
		/// </summary>
		public long? Value { get; set; }
		/// <summary>
		/// 발견또는 레벨변경일시 또는 미사용
		/// </summary>
		public DateTime? DateTime { get; set; }
	}
}
