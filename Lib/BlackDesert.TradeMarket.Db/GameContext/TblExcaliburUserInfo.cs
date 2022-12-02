namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblExcaliburUserInfo
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public int DrawExcaliburCount { get; set; }
		public DateTime ResetTime { get; set; }
	}
}
