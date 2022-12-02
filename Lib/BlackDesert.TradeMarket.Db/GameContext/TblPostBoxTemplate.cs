namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPostBoxTemplate
	{
		public int TemplateNo { get; set; }
		public string? Title { get; set; }
		public string? SenderName { get; set; }
		public string? Message { get; set; }
		public string? Memo { get; set; }
	}
}
