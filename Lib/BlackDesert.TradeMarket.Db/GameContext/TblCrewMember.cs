namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCrewMember
	{
		public DateTime RegisterDate { get; set; }
		public long CrewNo { get; set; }
		public long UserNo { get; set; }
		public byte Grade { get; set; }
		public int WinCount { get; set; }
		public int LoseCount { get; set; }
	}
}
