namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMansionListForTownManagement
	{
		public long UserNo { get; set; }
		public int LandKey { get; set; }
		public long HouseholdNoLand { get; set; }
		public int InteriorSensePointLand { get; set; }
		public int BasePointLand { get; set; }
		public int EmptyPointLand { get; set; }
		public int BonusPointLand { get; set; }
		public int BuildingKey { get; set; }
		public long HouseholdNoBuilding { get; set; }
		public int InteriorSensePointBuilding { get; set; }
		public int BasePointBuilding { get; set; }
		public int EmptyPointBuilding { get; set; }
		public int BonusPointBuilding { get; set; }
		public int InteriorSensePoint { get; set; }
		public int SetPoint { get; set; }
		public DateTime? InteriorUpdateTime { get; set; }
	}
}
