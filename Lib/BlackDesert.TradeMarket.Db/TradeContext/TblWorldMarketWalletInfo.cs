namespace BlackDesert.TradeMarket.Db.TradeContext
{
	public partial class TblWorldMarketWalletInfo
	{
		public int NationCode { get; set; }
		public int ServerNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public string UserId { get; set; } = null!;
		public long PersonalTradeBuyCount { get; set; }
		public long PersonalTradeSellCount { get; set; }
		public DateTime ResetTime { get; set; }
		public long Weight { get; set; }
		public long AddWeight { get; set; }
		public DateTime PackageExpiration { get; set; }
		public DateTime PearlItemLimitedresetTime { get; set; }
		public long PearlItemLimitedCount { get; set; }
		public int AddPearlItemLimitedCount { get; set; }
		public int MaidCount { get; set; }
		public bool IsGameMaster { get; set; }
		public DateTime RegisterDate { get; set; }
		public double AddTaxDiscountRate { get; set; }
		public DateTime BlackUserCheckTime { get; set; }
		public int BlackUserCheckCount { get; set; }
		public int FamilySkillAddTaxDiscountRate { get; set; }
		public DateTime? LastSecondPwdFailDate { get; set; }
		public byte SecondPwdFailCount { get; set; }
		public DateTime AddWeightBuffExpiration { get; set; }
		public long AddWeightByBuff { get; set; }
		public DateTime? LastConfirmOtpTime { get; set; }
	}
}
