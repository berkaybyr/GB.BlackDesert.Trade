namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 고용되어 사용중인 Npc
	/// </summary>
	public partial class TblUsingHiredNpc
	{
		/// <summary>
		/// 등록일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 소유 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 액터키
		/// </summary>
		public long ActorKey { get; set; }
		/// <summary>
		/// 캐릭터키
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 만료일
		/// </summary>
		public DateTime ExpiredTime { get; set; }
	}
}
