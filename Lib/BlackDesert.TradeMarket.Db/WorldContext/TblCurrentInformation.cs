namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 현재정보
	/// </summary>
	public partial class TblCurrentInformation
	{
		/// <summary>
		/// 수정시간
		/// </summary>
		public DateTime UpdatedDate { get; set; }
		/// <summary>
		/// 월드번호
		/// </summary>
		public short WorldNo { get; set; }
		/// <summary>
		/// 서버번호
		/// </summary>
		public short ServerNo { get; set; }
		/// <summary>
		/// 총세션수
		/// </summary>
		public int TotalSessionCount { get; set; }
		/// <summary>
		/// 사용중인 세션수
		/// </summary>
		public int BusySessionCount { get; set; }
		/// <summary>
		/// ID PW는 맞는데 아직 필드 진입하지 않은 수
		/// </summary>
		public int LoginningUserCount { get; set; }
		/// <summary>
		/// 플레이중인 이용자 수
		/// </summary>
		public int PlayingUserCount { get; set; }
		public int PcRoomUserCount { get; set; }
	}
}
