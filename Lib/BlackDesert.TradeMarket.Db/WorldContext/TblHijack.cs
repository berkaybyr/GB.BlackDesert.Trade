namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblHijack
	{
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _adminUserNo
		/// </summary>
		public long AdminUserNo { get; set; }
		/// <summary>
		/// _hijackUserNo
		/// </summary>
		public long HijackUserNo { get; set; }
	}
}
