namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblRentInstanceField
	{
		public short ServerNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public int UniqueIndex { get; set; }
		public long HostUserNo { get; set; }
		public string HostUserNickName { get; set; } = null!;
		public int InstanceFieldMapKey { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public int ReCount { get; set; }
	}
}
