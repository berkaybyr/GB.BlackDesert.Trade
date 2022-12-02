namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblPs4devAccessUserList
	{
		public string TokenKey { get; set; } = null!;
		public string UserId { get; set; } = null!;
		public string Ps4UserId { get; set; } = null!;
		public string AccessIp { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
		public DateTime? UsedDate { get; set; }
	}
}
