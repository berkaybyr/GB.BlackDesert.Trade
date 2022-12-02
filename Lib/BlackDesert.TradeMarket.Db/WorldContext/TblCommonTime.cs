namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 시간 테이블
	/// </summary>
	public partial class TblCommonTime
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public short WorldNo { get; set; }
		/// <summary>
		/// 서버가 켜진 시간
		/// </summary>
		public DateTime? ServerOpenTime { get; set; }
		/// <summary>
		/// 서버의 마지막 업데이트 시간
		/// </summary>
		public DateTime? LastUpdateTime { get; set; }
		/// <summary>
		/// 서버 누적 시간(서버가 켜진 상태에서만 누적됨)
		/// </summary>
		public long CumulatedTick { get; set; }
	}
}
