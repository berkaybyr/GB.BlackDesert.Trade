namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonChangeLog
	{
		public int? Season { get; set; }
		public string? Message { get; set; }
		public int? Type { get; set; }
		public bool? IsSuccess { get; set; }
		public DateTime? RegisterDate { get; set; }
	}
}
