namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblDailyBattlePassPoint
	{
		public long UserNo { get; set; }
		public byte Type { get; set; }
		public int Point { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
