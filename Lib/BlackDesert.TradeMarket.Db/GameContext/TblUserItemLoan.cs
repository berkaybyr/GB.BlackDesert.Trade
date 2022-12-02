namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저의 아이템 반납 정보
	/// </summary>
	public partial class TblUserItemLoan
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 아이템 키
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// 인챈트 레벨
		/// </summary>
		public byte EnchantLevel { get; set; }
		/// <summary>
		/// 개수
		/// </summary>
		public long Count { get; set; }
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
