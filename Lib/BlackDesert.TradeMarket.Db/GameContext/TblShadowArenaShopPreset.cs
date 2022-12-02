namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaShopPreset
	{
		public long UserNo { get; set; }
		public short InstanceContentsType { get; set; }
		public short InstanceContentsMode { get; set; }
		public byte ClassType { get; set; }
		public int PresetIndex { get; set; }
		public string PresetName { get; set; } = null!;
		public string ItemRoute { get; set; } = null!;
	}
}
