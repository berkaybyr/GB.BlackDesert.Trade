namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblChatBlockByUser
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public DateTime? EndDate { get; set; }
		public short Point { get; set; }
	}
}
