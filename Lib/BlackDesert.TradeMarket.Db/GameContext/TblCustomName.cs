namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 커스터마이징 된 이름 TABLE
	/// </summary>
	public partial class TblCustomName
	{
		/// <summary>
		/// 타입
		/// </summary>
		public short Type { get; set; }
		/// <summary>
		/// 파라메터
		/// </summary>
		public long Param { get; set; }
		/// <summary>
		/// 유저가 작성한 이름
		/// </summary>
		public string Name { get; set; } = null!;
		/// <summary>
		/// 생성/변경일
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
