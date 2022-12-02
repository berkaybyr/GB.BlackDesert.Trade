namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblNameExchangeComplete
	{
		public DateTime RegisterDate { get; set; }
		public long OwnerNo { get; set; }
		public long CharacterNo1 { get; set; }
		public long CharacterNo2 { get; set; }
		public DateTime ChangedDate { get; set; }
	}
}
