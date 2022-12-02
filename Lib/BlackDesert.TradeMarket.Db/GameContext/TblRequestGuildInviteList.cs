namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblRequestGuildInviteList
	{
		public DateTime RegisterDate { get; set; }
		public long HostUserNo { get; set; }
		public long HostGuildNo { get; set; }
		public long ReceiveUserNo { get; set; }
		public long ContractBenefit { get; set; }
		public long ContractPenalty { get; set; }
		public int ContractDay { get; set; }
	}
}
