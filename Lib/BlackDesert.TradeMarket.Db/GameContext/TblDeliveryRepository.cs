namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아이템 운송 정보
	/// </summary>
	public partial class TblDeliveryRepository
	{
		public short ServerNo { get; set; }
		/// <summary>
		/// 유저 고유 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 운송 상태
		/// </summary>
		public byte Progress { get; set; }
		/// <summary>
		/// 출발 지역 번호
		/// </summary>
		public int From { get; set; }
		/// <summary>
		/// 도착 지역 번호
		/// </summary>
		public int To { get; set; }
		/// <summary>
		/// 운송하는 객체 번호
		/// </summary>
		public long? DelivererNo { get; set; }
		/// <summary>
		/// 운송하는 객체 타입
		/// </summary>
		public byte DelivererType { get; set; }
		/// <summary>
		/// 운송 노선 번호
		/// </summary>
		public int DeliveryRoute { get; set; }
		/// <summary>
		/// 아이템 번호
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
