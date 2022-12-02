namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblParty
	{
		public long PartyId { get; set; }
		public long UserNo { get; set; }
		public bool IsPartyLeader { get; set; }
	}
}
