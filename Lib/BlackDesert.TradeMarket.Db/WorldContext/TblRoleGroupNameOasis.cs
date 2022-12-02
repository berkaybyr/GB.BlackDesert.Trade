namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblRoleGroupNameOasis
	{
		public byte RoleGroupNo { get; set; }
		public string RoleGroupName { get; set; } = null!;
		public string RoleGroupMemo { get; set; } = null!;
		public byte RoleGroupGrade { get; set; }
	}
}
