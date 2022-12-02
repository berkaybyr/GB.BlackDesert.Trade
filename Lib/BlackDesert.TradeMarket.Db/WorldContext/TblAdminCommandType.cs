namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblAdminCommandType
	{
		public int CommandTypeNo { get; set; }
		public string? Command { get; set; }
		public int ParamCount { get; set; }
		public string? CommandDesc { get; set; }
		public string? ParamDesc { get; set; }
	}
}
