namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlackSpiritAdventureQuest
	{
		public long UserNo { get; set; }
		public int QuestNo { get; set; }
		public int QuestGroupIndex { get; set; }
		public int QuestSequence { get; set; }
		public int MonsterKey { get; set; }
		public bool IsBossQuest { get; set; }
		public bool IsComplete { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? CompleteDate { get; set; }
	}
}
