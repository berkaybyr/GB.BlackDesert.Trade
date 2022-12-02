namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblRestoreItemUserInfo
	{
		public long UserNo { get; set; }
		public byte RestoreType { get; set; }
		public DateTime NextResetDate { get; set; }
		public int Count { get; set; }
	}
}
