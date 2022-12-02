namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblWebBenefit
	{
		public DateTime RegisterDate { get; set; }
		public bool IsUserNo { get; set; }
		public long OwnerNo { get; set; }
		public int BenefitType { get; set; }
		public long Param0 { get; set; }
		public long Param1 { get; set; }
	}
}
