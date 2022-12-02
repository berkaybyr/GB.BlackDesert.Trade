namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblFeverPoint
	{
		public long UserNo { get; set; }
		public int FeverPoint { get; set; }
		public int MaxFeverPoint { get; set; }
		public int AddFeverPoint { get; set; }
		public DateTime LastAddPointTime { get; set; }
		public short UseFeverSkillIndex { get; set; }
		public bool? IsUseFeverSkill { get; set; }
	}
}
