namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCommonContentsScoreRecord
	{
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public short ContentsType { get; set; }
		public short Mode { get; set; }
		public short Stage { get; set; }
		public long Score { get; set; }
		public DateTime RegisterDate { get; set; }
	}
}
