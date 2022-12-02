namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblItemToInventoryRequest
	{
		public int RequestNo { get; set; }
		public long RequestUserNo { get; set; }
		public long? ConfirmUserNo { get; set; }
		public DateTime RequestedDate { get; set; }
		public bool IsSended { get; set; }
		public string NoteNo { get; set; } = null!;
		public string? NoteUrl { get; set; }
		public long CharacterNo { get; set; }
		public byte ToWhere { get; set; }
		public int ItemKey { get; set; }
		public byte EnchantLevel { get; set; }
		public bool IsStack { get; set; }
		public bool IsVested { get; set; }
		public int Endurance { get; set; }
		public int MaxEndurance { get; set; }
		public long ItemCount { get; set; }
	}
}
