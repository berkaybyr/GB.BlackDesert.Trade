namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblInstanceFieldOnlineUserRanking
	{
		public int Ranking { get; set; }
		public long UserNo { get; set; }
		public int InstanceFieldKey { get; set; }
		public bool IsNormal { get; set; }
	}
}
