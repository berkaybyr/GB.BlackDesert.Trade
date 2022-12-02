namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 버프의 유효시간
	/// </summary>
	public partial class TblBuffExpirationDate
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 버프 종류 =&gt; enum값과 연결됨
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 버프 만료일시(절대시간임) =&gt; NULL 이거나 과거면 버프 없음.
		/// </summary>
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// 버프 레벨.
		/// </summary>
		public int Level { get; set; }
		public int Param1 { get; set; }
	}
}
