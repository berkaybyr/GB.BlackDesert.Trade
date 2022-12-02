namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 친구 그룹
	/// </summary>
	public partial class TblFriendGroup
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 그룹번호
		/// </summary>
		public int GroupNo { get; set; }
		/// <summary>
		/// 그룹이름
		/// </summary>
		public string GroupName { get; set; } = null!;
	}
}
