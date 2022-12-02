namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 친구 목록
	/// </summary>
	public partial class TblFriend
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 친구 유저번호
		/// </summary>
		public long FriendUserNo { get; set; }
		/// <summary>
		/// 그룹번호
		/// </summary>
		public int GroupNo { get; set; }
		/// <summary>
		/// 0 일반,1 파티
		/// </summary>
		public int FriendType { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
