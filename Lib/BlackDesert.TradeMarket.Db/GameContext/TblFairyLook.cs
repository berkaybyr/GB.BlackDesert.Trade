namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 요정 외형
	/// </summary>
	public partial class TblFairyLook
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 소유 사용자번호
		/// </summary>
		public long OwnerUserNo { get; set; }
		/// <summary>
		/// 바꿀외형 번호
		/// </summary>
		public int ActionIndex { get; set; }
	}
}
