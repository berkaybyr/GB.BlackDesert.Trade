namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblLeaveBriefUserInformation
	{
		public DateTime? LeaveDate { get; set; }
		public DateTime? RegisterDate { get; set; }
		public string? UserId { get; set; }
		public long? UserNo { get; set; }
		public string? UserNickname { get; set; }
		public string? TmpName { get; set; }
	}
}
