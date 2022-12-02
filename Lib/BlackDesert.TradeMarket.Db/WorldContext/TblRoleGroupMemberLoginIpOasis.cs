namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblRoleGroupMemberLoginIpOasis
	{
		public byte WhereType { get; set; }
		public long WhereNo { get; set; }
		public string IpAddress { get; set; } = null!;
	}
}
