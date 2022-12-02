namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMassPlayerTitleRequest
	{
		public long No { get; set; }
		public DateTime? RegisterDate { get; set; }
		public string? UserIdString { get; set; }
		public long? TitleKey { get; set; }
	}
}
