namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonResetMail
	{
		public string? Region { get; set; }
		public int? InfoNo { get; set; }
		public string? Info { get; set; }
		public string? SenderName { get; set; }
		public string? Title { get; set; }
		public string? Contents { get; set; }
		public int? ItemKey { get; set; }
		public int? ItemCount { get; set; }
	}
}
