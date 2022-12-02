namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaSkillAwakenList
	{
		public long UserNo { get; set; }
		public byte ClassType { get; set; }
		public int SkillNo { get; set; }
		public bool IsSelect { get; set; }
	}
}
