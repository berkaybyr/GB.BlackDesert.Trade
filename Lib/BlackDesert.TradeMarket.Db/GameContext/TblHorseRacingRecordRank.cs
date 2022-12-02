namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblHorseRacingRecordRank
	{
		public long UserNo { get; set; }
		public string UserNickname { get; set; } = null!;
		public string ServantName { get; set; } = null!;
		public int Season { get; set; }
		public int Rank { get; set; }
		public byte MapKey { get; set; }
		public long RecordTick { get; set; }
		public DateTime RecordDate { get; set; }
	}
}
