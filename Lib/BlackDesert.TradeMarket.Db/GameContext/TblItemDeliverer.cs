namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아이템 운송을 담당하는 객체 정보
	/// </summary>
	public partial class TblItemDeliverer
	{
		/// <summary>
		/// 등록 일시
		/// </summary>
		public DateTime RegisterDate { get; set; }
		public short ServerNo { get; set; }
		/// <summary>
		/// 운송 객체 고유 번호
		/// </summary>
		public long DelivererNo { get; set; }
		/// <summary>
		/// 현재 좌표(x)
		/// </summary>
		public long PositionX { get; set; }
		/// <summary>
		/// 현재 좌표(y)
		/// </summary>
		public long PositionY { get; set; }
		/// <summary>
		/// 현재 좌표(z)
		/// </summary>
		public long PositionZ { get; set; }
		/// <summary>
		/// 목적지 웨이포인트 키
		/// </summary>
		public long? DestinationKey { get; set; }
		/// <summary>
		/// 목적지 웨이포인트 이름
		/// </summary>
		public string? Destination { get; set; }
		/// <summary>
		/// 갱신 시간
		/// </summary>
		public DateTime? UpdateTime { get; set; }
	}
}
