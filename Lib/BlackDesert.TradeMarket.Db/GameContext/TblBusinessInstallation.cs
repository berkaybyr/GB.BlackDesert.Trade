namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 하우징 설치오브젝트 사업정보
	/// </summary>
	public partial class TblBusinessInstallation
	{
		/// <summary>
		/// 설치 오브젝트 번호
		/// </summary>
		public long InstallationNo { get; set; }
		/// <summary>
		/// 집 번호
		/// </summary>
		public long HouseholdNo { get; set; }
		/// <summary>
		/// 0자동판매1위탁판매
		/// </summary>
		public int BusinessType { get; set; }
		/// <summary>
		/// 판매기간
		/// </summary>
		public long SaleTime { get; set; }
		/// <summary>
		/// 판매수수료
		/// </summary>
		public double CommissionRate { get; set; }
		/// <summary>
		/// 최소등록비
		/// </summary>
		public long MinRegisterMoney { get; set; }
		/// <summary>
		/// 보유금액
		/// </summary>
		public long HoldingMoney { get; set; }
		/// <summary>
		/// 액티브여부
		/// </summary>
		public bool IsActive { get; set; }
	}
}
