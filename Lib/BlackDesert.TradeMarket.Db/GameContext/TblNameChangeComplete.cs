namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 이름 변경 완료
	/// </summary>
	public partial class TblNameChangeComplete
	{
		/// <summary>
		/// 신청 날짜
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 이름 변경 타입
		/// </summary>
		public int NameChangeType { get; set; }
		/// <summary>
		/// 변경을 요청한 유저 번호
		/// </summary>
		public long OwnerNo { get; set; }
		/// <summary>
		/// 변경할 이름
		/// </summary>
		public string Name { get; set; } = null!;
		/// <summary>
		/// 변경된 날짜
		/// </summary>
		public string? BeforeName { get; set; }
		/// <summary>
		/// 변경된 날짜
		/// </summary>
		public DateTime ChangedDate { get; set; }
	}
}
