namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblReturnStone
	{
		public long CharacterNo { get; set; }
		public long ReturnPositionX { get; set; }
		public long ReturnPositionY { get; set; }
		public long ReturnPositionZ { get; set; }
		public DateTime UsableDate { get; set; }
		public int ReturnRegionKey { get; set; }
		public byte TeleportType { get; set; }
	}
}
