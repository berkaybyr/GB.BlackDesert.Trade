namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblRentInstanceFieldPass
	{
		public short ServerNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public int UniqueIndex { get; set; }
		public long HostUserNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
	}
}
