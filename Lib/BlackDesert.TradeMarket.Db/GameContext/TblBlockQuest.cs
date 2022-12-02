namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblBlockQuest
	{
		public long BlockNo { get; set; }
		public DateTime RegisterDate { get; set; }
		public byte? QuestType { get; set; }
		public int? QuestGroupNo { get; set; }
		public int? QuestNo { get; set; }
		public string? ReasonMemo { get; set; }
	}
}
