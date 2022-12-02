namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 흑정령외형변경
	/// </summary>
	public partial class TblBlackSpiritForm
	{
		/// <summary>
		/// 소유 캐릭터
		/// </summary>
		public long CharacterNo { get; set; }
		/// <summary>
		/// 흑정령외형 인덱스
		/// </summary>
		public int BlackSpiritFormIndex { get; set; }
	}
}
