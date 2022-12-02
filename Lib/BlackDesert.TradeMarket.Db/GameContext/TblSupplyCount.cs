namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSupplyCount
	{
		public long UserNo { get; set; }
		public long TradeCountForSilver { get; set; }
		public long TradeCountForShell { get; set; }
		public DateTime NextResetTime { get; set; }
	}
}
