namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildWareHouseHistory
	{
		public DateTime RegisterDate { get; set; }
		public long GuildNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public int ItemKey { get; set; }
		public byte EnchantLevel { get; set; }
		public long ItemCount { get; set; }
		public bool IsPush { get; set; }
	}
}
