namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSyncLifeExperienceTran
	{
		public string? UserId { get; set; }
		public long CharacterNo { get; set; }
		public byte Type { get; set; }
		public int Level { get; set; }
		public int IsChange { get; set; }
	}
}
