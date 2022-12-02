namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblHarvestInstallation
	{
		public long InstallationNo { get; set; }
		public byte RemainLopCount { get; set; }
		public byte RemainPestCount { get; set; }
		public byte RemainBirdAttackCount { get; set; }
		public byte NextType { get; set; }
		public long RemainEventTime { get; set; }
	}
}
