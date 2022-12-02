namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserUsePearlForCashProduct
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 현재 스탬프 카운트
		/// </summary>
		public int StampCount { get; set; }
	}
}
