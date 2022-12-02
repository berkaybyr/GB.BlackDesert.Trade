namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저 아이템 네이밍
	/// </summary>
	public partial class TblItemNaming
	{
		/// <summary>
		/// 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저 넘버
		/// </summary>
		public long? UserNo { get; set; }
		/// <summary>
		/// 아이템 넘버
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// 작성자 이름
		/// </summary>
		public string UserNickname { get; set; } = null!;
		/// <summary>
		/// 작성자 이름
		/// </summary>
		public long? MailNo { get; set; }
	}
}
