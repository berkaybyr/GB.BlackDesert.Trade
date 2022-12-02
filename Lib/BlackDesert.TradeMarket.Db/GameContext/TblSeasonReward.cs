namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonReward
	{
		public long UserNo { get; set; }
		public int SelectedItemKey { get; set; }
		public byte SelectedItemEnchantLevel { get; set; }
	}
}
