namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaClanApplicant
	{
		public DateTime RegisterDate { get; set; }
		public long ClanNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
	}
}
