namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonCloseQuestWithReward
	{
		public int QuestGroupNo { get; set; }
		public int QuestNo { get; set; }
		public string? SenderName { get; set; }
		public string? Title { get; set; }
		public string? Contents { get; set; }
		public int? ItemKey { get; set; }
		public int? ItemCount { get; set; }
	}
}
