namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCharacterExpLoanLog
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public int Level { get; set; }
		public long BeforeExperience { get; set; }
		public long DecreaseExperience { get; set; }
	}
}
