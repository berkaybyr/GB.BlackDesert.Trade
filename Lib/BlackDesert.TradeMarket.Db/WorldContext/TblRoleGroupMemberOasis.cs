namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblRoleGroupMemberOasis
	{
		public byte WhereType { get; set; }
		public long WhereNo { get; set; }
		public byte RoleGroupNo { get; set; }
		public string? Password { get; set; }
		public DateTime? PasswordUpdateDate { get; set; }
		public string? PrevPassword1 { get; set; }
		public string? PrevPassword2 { get; set; }
		public string? PrevPassword3 { get; set; }
		public byte LoginAttemptCount { get; set; }
		public DateTime? LastLoginDate { get; set; }
		public string? RoleGroupMemberMemo { get; set; }
		public DateTime? ExtraTime { get; set; }
	}
}
