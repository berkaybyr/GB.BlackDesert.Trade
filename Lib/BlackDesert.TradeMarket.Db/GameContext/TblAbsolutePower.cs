namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 절대권력
	/// </summary>
	public partial class TblAbsolutePower
	{
		/// <summary>
		/// 저주 걸린 사용자 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 저주 타입
		/// </summary>
		public short CurseType { get; set; }
		/// <summary>
		/// 만기 시간
		/// </summary>
		public DateTime ExpirationTime { get; set; }
	}
}
