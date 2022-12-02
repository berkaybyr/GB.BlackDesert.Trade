namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 공성&amp;마을 정보
	/// </summary>
	public partial class TblSiege
	{
		/// <summary>
		/// 최초 등록시간
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _regionKey
		/// </summary>
		public int RegionKey { get; set; }
		/// <summary>
		/// 점령일시(주인이 없다면 해방일시)
		/// </summary>
		public DateTime OccupyingDate { get; set; }
		/// <summary>
		/// 주인이 없으면 0
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 성주가 설정한 세율
		/// </summary>
		public int TaxRateForSiege { get; set; }
		/// <summary>
		/// 성주가 인출할 수 있는 세금잔량
		/// </summary>
		public long TaxRemainedAmountForSiege { get; set; }
		/// <summary>
		/// 영주가 인출할 수 있는 세금잔량
		/// </summary>
		public long TaxRemainedAmountForFortress { get; set; }
		/// <summary>
		/// _taxRemainedAmount이 변경된 시간
		/// </summary>
		public DateTime UpdateDateOfTaxRemainedAmount { get; set; }
		/// <summary>
		/// 좋아요수 (약탈게임)
		/// </summary>
		public long Like { get; set; }
		/// <summary>
		/// 싫어요수 (약탈게임)
		/// </summary>
		public long Dislike { get; set; }
	}
}
