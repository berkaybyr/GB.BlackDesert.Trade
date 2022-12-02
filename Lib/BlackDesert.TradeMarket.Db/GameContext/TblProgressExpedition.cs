namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 토벌테이블
	/// </summary>
	public partial class TblProgressExpedition
	{
		/// <summary>
		/// 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 유닛 번호
		/// </summary>
		public long UnitNo { get; set; }
		/// <summary>
		/// 토벌 그룹
		/// </summary>
		public byte GroupKey { get; set; }
		/// <summary>
		/// 토벌 지역
		/// </summary>
		public byte SlotIndex { get; set; }
		/// <summary>
		/// 토벌 등록 시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
