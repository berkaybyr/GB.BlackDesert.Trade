namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblGuildSkillCoolTime
	{
		public long GuildNo { get; set; }
		public int SkillNo { get; set; }
		public DateTime ReusableTime { get; set; }
	}
}
