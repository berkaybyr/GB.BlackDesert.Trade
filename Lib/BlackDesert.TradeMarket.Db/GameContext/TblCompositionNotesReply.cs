namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCompositionNotesReply
	{
		public long ReplyNo { get; set; }
		public long NoteNo { get; set; }
		public long UserNo { get; set; }
		public string ReplyContent { get; set; } = null!;
		public short ReplyOrder { get; set; }
		public byte IsBlind { get; set; }
		public DateTime RegDate { get; set; }
		public DateTime UpdDate { get; set; }
		public string UserNickname { get; set; } = null!;
	}
}
