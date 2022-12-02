namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 캐릭터 커스터마이징
	/// </summary>
	public partial class TblCharacterCustomizing
	{
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 캐릭터 번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 별자리 키
		/// </summary>
		public byte ZodiacSignKey { get; set; }
		/// <summary>
		/// 두상 모양
		/// </summary>
		public byte HeadMesh { get; set; }
		/// <summary>
		/// 헤어 스타일
		/// </summary>
		public byte HairMesh { get; set; }
		public byte Extra0 { get; set; }
		public byte Extra1 { get; set; }
		public byte Extra2 { get; set; }
		public byte Extra3 { get; set; }
		/// <summary>
		/// 뼈대
		/// </summary>
		public byte[]? Bone { get; set; }
		/// <summary>
		/// 장식
		/// </summary>
		public byte[]? Decoration { get; set; }
		/// <summary>
		/// 표정
		/// </summary>
		public byte[] Expression { get; set; } = null!;
		public long VoiceType { get; set; }
		/// <summary>
		/// 원저작자
		/// </summary>
		public string? Author { get; set; }
		/// <summary>
		/// 캐릭터 커스터마이징 버전
		/// </summary>
		public int Version { get; set; }
		public long AuthorUserNo { get; set; }
		public bool? IsEditable { get; set; }
		public byte[]? DecorationRgb { get; set; }
	}
}
