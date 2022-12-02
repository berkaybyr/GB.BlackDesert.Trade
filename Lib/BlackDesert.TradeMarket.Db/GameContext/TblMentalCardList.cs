namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 카드 목록 테이블
	/// </summary>
	public partial class TblMentalCardList
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 소유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 카드키
		/// </summary>
		public int CardKey { get; set; }
		public int Level { get; set; }
	}
}
