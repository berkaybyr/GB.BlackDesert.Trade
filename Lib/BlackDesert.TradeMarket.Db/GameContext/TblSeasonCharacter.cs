namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblSeasonCharacter
	{
		public long? CharacterNo { get; set; }
		public long? UserNo { get; set; }
		public int? Season { get; set; }
		public bool IsDeleted { get; set; }
	}
}
