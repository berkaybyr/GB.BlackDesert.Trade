namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceFieldReadyUser
	{
		public long UserNo { get; set; }
		public short ServerNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public int UniqueIndex { get; set; }
		public DateTime ValidTime { get; set; }
		public bool IsEnterTheObserver { get; set; }
	}
}
