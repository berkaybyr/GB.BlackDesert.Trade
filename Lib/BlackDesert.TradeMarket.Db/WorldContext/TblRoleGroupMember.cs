namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblRoleGroupMember
	{
		public long UserNo { get; set; }
		public byte RoleGroupNo { get; set; }
		public string MacAddress { get; set; } = null!;
		public string IpAddress { get; set; } = null!;
		public string? PrevPassword1 { get; set; }
		public string? PrevPassword2 { get; set; }
		public string? PrevPassword3 { get; set; }
		public string? Password { get; set; }
		public DateTime? PasswordUpdateDate { get; set; }
	}
}
