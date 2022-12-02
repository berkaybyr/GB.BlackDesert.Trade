namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 펫
	/// </summary>
	public partial class TblPet
	{
		/// <summary>
		/// _registerDate
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// _petNo
		/// </summary>
		public long PetNo { get; set; }
		/// <summary>
		/// _characterKey
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 소유 사용자번호
		/// </summary>
		public long OwnerUserNo { get; set; }
		public string Name { get; set; } = null!;
		/// <summary>
		/// 펫의 레벨
		/// </summary>
		public int Level { get; set; }
		/// <summary>
		/// 펫의 경험치
		/// </summary>
		public long Experience { get; set; }
		/// <summary>
		/// 펫의 애정도
		/// </summary>
		public int Lovely { get; set; }
		/// <summary>
		/// 펫의 배고픔
		/// </summary>
		public int Hungry { get; set; }
		/// <summary>
		/// 펫의 외형
		/// </summary>
		public int ActionIndex { get; set; }
		/// <summary>
		/// _learnedFlag
		/// </summary>
		public long LearnedFlag { get; set; }
		/// <summary>
		/// _learnedEquipSkillFlag
		/// </summary>
		public long LearnedEquipSkillFlag { get; set; }
		/// <summary>
		/// 펫이 맡겨져있는지
		/// </summary>
		public bool? IsSealed { get; set; }
		/// <summary>
		/// 맡겨진 상태 값
		/// </summary>
		public byte PetState { get; set; }
		/// <summary>
		/// _petLootingType
		/// </summary>
		public byte PetLootingType { get; set; }
		/// <summary>
		/// _petType
		/// </summary>
		public byte PetType { get; set; }
		/// <summary>
		/// _upgradeStackCount
		/// </summary>
		public byte UpgradeStackCount { get; set; }
	}
}
