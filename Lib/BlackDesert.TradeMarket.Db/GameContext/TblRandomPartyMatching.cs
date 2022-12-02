namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblRandomPartyMatching
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public long EnterServerNo { get; set; }
	}
}
