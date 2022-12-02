namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaClanAssembleFlag
	{
		public long GuildNo { get; set; }
		public short ServerNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public int UniqueIndex { get; set; }
		public long PositionX { get; set; }
		public long PositionY { get; set; }
		public long PositionZ { get; set; }
		public DateTime SummonTime { get; set; }
	}
}
