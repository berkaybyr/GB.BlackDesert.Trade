namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCustomizingDownloadLog
	{
		public long CustomizingNo { get; set; }
		public long UserNo { get; set; }
		public DateTime DownloadDate { get; set; }
	}
}
