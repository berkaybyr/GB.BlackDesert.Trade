namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 이름 변경 요청
	/// </summary>
	public partial class TblNameChange
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
		/// 변경전 이름
		/// </summary>
		public string? BeforeName { get; set; }
		/// <summary>
		/// 불건전한 이름 확인 여부
		/// </summary>
		public bool IsBadName { get; set; }
	}
}
