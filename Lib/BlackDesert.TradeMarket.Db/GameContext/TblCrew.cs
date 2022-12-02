namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblCrew
	{
		public DateTime RegisterDate { get; set; }
		public long CrewNo { get; set; }
		public string CrewName { get; set; } = null!;
		public long MasterUserNo { get; set; }
		public string MasterUserNickname { get; set; } = null!;
		public string? CrewNotice { get; set; }
		public int WinCount { get; set; }
		public int LoseCount { get; set; }
	}
}
