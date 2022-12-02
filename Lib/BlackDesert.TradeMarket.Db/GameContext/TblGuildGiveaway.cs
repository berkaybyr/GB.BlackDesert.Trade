namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildGiveaway
	{
		public long Index { get; set; }
		public int Key { get; set; }
		public long GuildNo { get; set; }
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
		public DateTime DeleteDate { get; set; }
	}
}
