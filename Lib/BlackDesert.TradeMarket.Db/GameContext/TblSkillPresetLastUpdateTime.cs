namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSkillPresetLastUpdateTime
	{
		public long UserNo { get; set; }
		public DateTime? LastUpdateTimeNpc { get; set; }
		public DateTime? LastUpdateTimeBuff { get; set; }
	}
}
