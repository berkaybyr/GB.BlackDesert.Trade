namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPearlUsedLastMonthAmount
	{
		public DateTime LastRegisterDate { get; set; }
		public long UserNo { get; set; }
		public long PearlObtainedMonthly { get; set; }
		public long PearlUsedMonthly { get; set; }
	}
}
