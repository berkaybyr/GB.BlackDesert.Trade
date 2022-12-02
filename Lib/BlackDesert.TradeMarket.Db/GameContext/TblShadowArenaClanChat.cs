namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaClanChat
	{
		public long ChatIdx { get; set; }
		public long FromUserNo { get; set; }
		public string FromUserId { get; set; } = null!;
		public byte ChatType { get; set; }
		public byte LangType { get; set; }
		public long EmoticonPackKey { get; set; }
		public long ChatRoomNo { get; set; }
		public byte ResType { get; set; }
		public string ChatMsg { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
	}
}
