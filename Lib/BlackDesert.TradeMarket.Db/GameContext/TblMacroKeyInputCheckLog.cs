namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMacroKeyInputCheckLog
	{
		public long UserNo { get; set; }
		public DateTime StartDate { get; set; }
		public int InputCount { get; set; }
		public string? TextParam1 { get; set; }
		public string? TextParam2 { get; set; }
		public string? TextParam3 { get; set; }
		public string? TextParam4 { get; set; }
	}
}
