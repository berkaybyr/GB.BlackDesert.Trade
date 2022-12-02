namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMailWaitingQueue
	{
		public long WaitingNo { get; set; }
		public long? MailRequestNo { get; set; }
		public long? UserNo { get; set; }
	}
}
