namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 친구 요청 리스트
	/// </summary>
	public partial class TblAddFriendList
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 친구요청 유저번호
		/// </summary>
		public long RequestUserNo { get; set; }
	}
}
