namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 로그아웃중인 플레이어의 작업목록
	/// </summary>
	public partial class TblLogoutPlayerWorking
	{
		/// <summary>
		/// 캐릭의 고유한 번호(OdbcCharacterNo)
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 소유 사용자번호
		/// </summary>
		public long OwnerUserNo { get; set; }
		/// <summary>
		/// 작업의 종류(0: 없음, 1: 수리, 2: 마을이동)
		/// </summary>
		public int ProcessType { get; set; }
		/// <summary>
		/// 해당 작업으로 이동할 Waypoint 번호이다. (현재 마을이동 이외의 경우에는 NULL)
		/// </summary>
		public int? ToWaypoint { get; set; }
		/// <summary>
		/// 해당 작업에 관련된 아이템 번호(OdbcItemNo) (수리시에는 수리할 아이템, 마을 이동시에는 운송화된 아이템번호)
		/// </summary>
		public int RepairItemNo { get; set; }
		/// <summary>
		/// 작업 시작일
		/// </summary>
		public DateTime RegisterDate { get; set; }
	}
}
