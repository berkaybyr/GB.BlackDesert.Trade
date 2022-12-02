namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaAttendance
	{
		public long UserNo { get; set; }
		public int Key { get; set; }
		public byte Day { get; set; }
		public DateTime? ReceiveDate { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
