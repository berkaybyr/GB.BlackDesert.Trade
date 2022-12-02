namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 하우징 설치 InstanceObject 테이블
	/// </summary>
	public partial class TblInstalledInstanceObject
	{
		/// <summary>
		/// 설치된 설치물의 고유번호
		/// </summary>
		public long InstanceObjectNo { get; set; }
		/// <summary>
		/// 설치된 설치물의 종류
		/// </summary>
		public byte ObjectType { get; set; }
		/// <summary>
		/// 설치된 설치물의 캐릭터키
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 소속 길드번호
		/// </summary>
		public long GuildNo { get; set; }
		/// <summary>
		/// 캐릭을 소유한 사용자번호(정상적인 캐릭터라면 TUserNoDefault 이면 안됨)	
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 소유자 사용자캐릭터번호
		/// </summary>
		public long UserCharacterNo { get; set; }
		public long HouseholdNo { get; set; }
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
		public double PosX { get; set; }
		/// <summary>
		/// _posY
		/// </summary>
		public double PosY { get; set; }
		/// <summary>
		/// _posZ
		/// </summary>
		public double PosZ { get; set; }
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
	}
}
