namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblPartyMatching
	{
		public long MatchId { get; set; }
		public int InstanceFieldKey { get; set; }
		public int MemberCount { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
