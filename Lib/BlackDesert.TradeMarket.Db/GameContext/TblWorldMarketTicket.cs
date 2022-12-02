namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblWorldMarketTicket
	{
		public long UserNo { get; set; }
		public Guid? TicketNo { get; set; }
		public byte Type { get; set; }
		public DateTime LastUpdateTime { get; set; }
	}
}
