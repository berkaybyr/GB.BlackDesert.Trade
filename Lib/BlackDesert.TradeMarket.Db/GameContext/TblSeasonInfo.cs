namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonInfo
	{
		public int? Season { get; set; }
		public string? SeasonName { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
	}
}
