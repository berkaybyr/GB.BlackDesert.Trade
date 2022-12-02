namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblShadowArenaLastBattleResultInfo
	{
		public long UserNo { get; set; }
		public short ChangeTierPoint { get; set; }
		public bool IsReceiveReward { get; set; }
		public int InstanceFieldKey { get; set; }
		public long RewardMoney { get; set; }
		public byte Kill { get; set; }
		public byte Death { get; set; }
		public byte Assist { get; set; }
		public int Ranking { get; set; }
	}
}
