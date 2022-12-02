namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 탈것 장착 메시 보이기on/off
	/// </summary>
	public partial class TblUserUiinfomation
	{
		/// <summary>
		/// 게임내 고유 유저번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 말 탈것 장비
		/// </summary>
		public int HorseVehicleEquipFlag { get; set; }
		/// <summary>
		/// 낙타 탈것 장비
		/// </summary>
		public int CamelVehicleEquipFlag { get; set; }
		/// <summary>
		/// 아바타 장착
		/// </summary>
		public int AvatarEquipSlotFlag { get; set; }
		/// <summary>
		/// 안면 보호대
		/// </summary>
		public bool IsBattleHelmShow { get; set; }
		/// <summary>
		/// 망토 보이기 on/off
		/// </summary>
		public bool? IsCloakShow { get; set; }
	}
}
