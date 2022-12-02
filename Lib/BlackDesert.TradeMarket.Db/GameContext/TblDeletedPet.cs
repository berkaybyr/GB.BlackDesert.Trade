namespace BlackDesert.TradeMarket.Db.GameContext
{
	public partial class TblDeletedPet
	{
		public DateTime? DeletedDate { get; set; }
		public DateTime? RegisterDate { get; set; }
		public long? PetNo { get; set; }
		public int? CharacterKey { get; set; }
		public long? OwnerUserNo { get; set; }
		public string? Name { get; set; }
		public int? Level { get; set; }
		public long? Experience { get; set; }
		public int? Lovely { get; set; }
		public int? Hungry { get; set; }
		public int? ActionIndex { get; set; }
		public long? LearnedFlag { get; set; }
		public long? LearnedEquipSkillFlag { get; set; }
		public bool? IsSealed { get; set; }
		public byte? PetState { get; set; }
		public byte? PetLootingType { get; set; }
		public byte? PetType { get; set; }
		public byte? UpgradeStackCount { get; set; }
	}
}
