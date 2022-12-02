namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblTeenageUserInformation
	{
		public DateTime RegisterDate { get; set; }
		public string UserId { get; set; } = null!;
		public long UserNo { get; set; }
		public byte TeenAgeType { get; set; }
	}
}
