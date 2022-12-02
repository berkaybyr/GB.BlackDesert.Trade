namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblUserNpcCustomizing
	{
		public long CharacterNo { get; set; }
		public byte HeadMesh { get; set; }
		public byte HairMesh { get; set; }
		public byte Extra0 { get; set; }
		public byte Extra1 { get; set; }
		public byte Extra2 { get; set; }
		public byte Extra3 { get; set; }
		public byte[]? Bone { get; set; }
		public byte[]? Decoration { get; set; }
		public byte[]? DecorationRgb { get; set; }
		public byte[] Expression { get; set; } = null!;
		public int SeqNo { get; set; }
	}
}
