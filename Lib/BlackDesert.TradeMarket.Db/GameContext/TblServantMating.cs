namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 말 교배 정보
	/// </summary>
	public partial class TblServantMating
	{
		/// <summary>
		/// 교배 고유 번호
		/// </summary>
		public long MatingNo { get; set; }
		/// <summary>
		/// 교배 시작 시간
		/// </summary>
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 교배 종료 시간
		/// </summary>
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 암컷 말 고유 번호
		/// </summary>
		public long FemaleServantNo { get; set; }
		/// <summary>
		/// 수컷 말 고유 번호
		/// </summary>
		public long MaleServantNo { get; set; }
		/// <summary>
		/// 망아지 캐릭터 키
		/// </summary>
		public int ChildCharacterKey { get; set; }
		/// <summary>
		/// 수컷 말 종마 구분
		/// </summary>
		public bool? IsMaleStallion { get; set; }
	}
}
