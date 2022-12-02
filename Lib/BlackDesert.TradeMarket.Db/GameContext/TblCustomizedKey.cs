namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 유저 캐릭을 위한 key 설정 정보
	/// </summary>
	public partial class TblCustomizedKey
	{
		/// <summary>
		/// 캐릭터번호
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 키보드 ActionInputType 설정 데이터
		/// </summary>
		public string KeyActionInputSerializedData { get; set; } = null!;
		/// <summary>
		/// 키보드 UiInputType 설정 데이터
		/// </summary>
		public string KeyUiInputSerializedData { get; set; } = null!;
		/// <summary>
		/// 패드 ActionInputType 설정 데이터
		/// </summary>
		public string PadActionInputSerializedData { get; set; } = null!;
		/// <summary>
		/// 패드 UiInputType 설정 데이터
		/// </summary>
		public string PadUiInputSerializedData { get; set; } = null!;
		/// <summary>
		/// 패드 기능키 1
		/// </summary>
		public byte? PadFunctionInput1 { get; set; }
		/// <summary>
		/// 패드 기능키 2
		/// </summary>
		public byte? PadFunctionInput2 { get; set; }
	}
}
