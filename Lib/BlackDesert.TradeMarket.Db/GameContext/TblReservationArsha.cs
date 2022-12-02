namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 아르샤의 창 예약
	/// </summary>
	public partial class TblReservationArsha
	{
		/// <summary>
		/// 예약 채널 번호
		/// </summary>
		public short ServerNo { get; set; }
		/// <summary>
		/// 예약 등록시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		public DateTime ReservationDay { get; set; }
		/// <summary>
		/// 예약 길드 번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 예약 길드 이름
		/// </summary>
		public string GuildName { get; set; } = null!;
	}
}
