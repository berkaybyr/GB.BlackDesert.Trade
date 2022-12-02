namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMusicScore
	{
		public DateTime RegisterDate { get; set; }
		public long MusicScoreNo { get; set; }
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public short Version { get; set; }
		public short Size { get; set; }
		public byte[] MusicScore { get; set; } = null!;
	}
}
