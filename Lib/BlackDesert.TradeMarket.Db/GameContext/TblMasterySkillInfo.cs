namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblMasterySkillInfo
	{
		public long UserNo { get; set; }
		public byte ClassType { get; set; }
		public int InstanceFieldKey { get; set; }
		public long SkillNo { get; set; }
		public bool IsBattle { get; set; }
	}
}
