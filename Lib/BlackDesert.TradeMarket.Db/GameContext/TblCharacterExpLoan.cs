namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCharacterExpLoan
	{
		public DateTime RegisterDate { get; set; }
		public long UserNo { get; set; }
		public long CharacterNo { get; set; }
		public long TotalExperience { get; set; }
		public long LeftExperience { get; set; }
	}
}
