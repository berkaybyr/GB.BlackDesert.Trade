namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblTradeCompany
	{
		public long OwnerUserNo { get; set; }
		public bool IsActiveWorkerTrade { get; set; }
		public long Money { get; set; }
		public int Carriage { get; set; }
		public int Amulet { get; set; }
		public int Porter { get; set; }
		public int Guard { get; set; }
	}
}
