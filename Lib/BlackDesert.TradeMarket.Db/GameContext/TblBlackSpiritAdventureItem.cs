namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlackSpiritAdventureItem
	{
		public long UserNo { get; set; }
		public int WebItemKey { get; set; }
		public int ItemCount { get; set; }
		public byte UseCondition { get; set; }
	}
}
