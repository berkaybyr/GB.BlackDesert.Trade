namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 하우징 하우스홀드 텐트 테이블
	/// </summary>
	public partial class TblHouseholdTent
	{
		/// <summary>
		/// _householdNo
		/// </summary>
		public long HouseholdNo { get; set; }
		/// <summary>
		/// 아이템번호(아이템테이블과 연결)
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// 설치하기 전에 사용한 텐트 아이템 키
		/// </summary>
		public int ItemKey { get; set; }
		/// <summary>
		/// _fieldNo
		/// </summary>
		public short FieldNo { get; set; }
		/// <summary>
		/// _fieldIndex
		/// </summary>
		public short FieldIndex { get; set; }
		/// <summary>
		/// _posX
		/// </summary>
		public float PosX { get; set; }
		/// <summary>
		/// _posY
		/// </summary>
		public float PosY { get; set; }
		/// <summary>
		/// _posZ
		/// </summary>
		public float PosZ { get; set; }
		/// <summary>
		/// _dirX
		/// </summary>
		public double DirX { get; set; }
		/// <summary>
		/// _dirY
		/// </summary>
		public double DirY { get; set; }
		/// <summary>
		/// _dirZ
		/// </summary>
		public double DirZ { get; set; }
		public long TerritoryKey { get; set; }
		/// <summary>
		/// _buildProgressPoint0
		/// </summary>
		public int BuildProgressPoint0 { get; set; }
		/// <summary>
		/// _buildProgressPoint1
		/// </summary>
		public int BuildProgressPoint1 { get; set; }
		/// <summary>
		/// _buildProgressPoint2
		/// </summary>
		public int BuildProgressPoint2 { get; set; }
		/// <summary>
		/// _buildProgressPoint3
		/// </summary>
		public int BuildProgressPoint3 { get; set; }
		/// <summary>
		/// _buildProgressPoint4
		/// </summary>
		public int BuildProgressPoint4 { get; set; }
		public long? BuildGuildNo { get; set; }
		public DateTime BuildCreatedDate { get; set; }
		public DateTime? BuildCompletedDate { get; set; }
		public DateTime? BuildDestroyedDate { get; set; }
		public long? BuildDestroyerGuildNo { get; set; }
		/// <summary>
		/// _growingRate0
		/// </summary>
		public int GrowingRate0 { get; set; }
		/// <summary>
		/// _growingRate1
		/// </summary>
		public int GrowingRate1 { get; set; }
		/// <summary>
		/// _growingRate2
		/// </summary>
		public int GrowingRate2 { get; set; }
		/// <summary>
		/// 설치한 곳의 지역 키
		/// </summary>
		public int? BuildRegionKey { get; set; }
		/// <summary>
		/// 지역의 세금 단계
		/// </summary>
		public byte? RegionTaxLevel { get; set; }
		/// <summary>
		/// 파괴한 캐릭터 번호
		/// </summary>
		public long? DestroyerCharacterNo { get; set; }
		/// <summary>
		/// 파괴한 캐릭터 명
		/// </summary>
		public string? DestroyerCharacterName { get; set; }
	}
}
