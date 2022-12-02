namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 성장 단계 테이블
	/// </summary>
	public partial class TblGrowStep
	{
		/// <summary>
		/// 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 성장 단계 키
		/// </summary>
		public short GrowStepKey { get; set; }
		/// <summary>
		/// 성장 단계 오픈여부
		/// </summary>
		public bool IsOpen { get; set; }
	}
}
