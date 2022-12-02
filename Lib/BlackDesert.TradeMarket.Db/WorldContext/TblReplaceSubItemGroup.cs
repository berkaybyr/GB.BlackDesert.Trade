namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 변경할 드랍그룹(일본용)
	/// </summary>
	public partial class TblReplaceSubItemGroup
	{
		/// <summary>
		/// 아이템드랍엑셀의 서브그룹키(ItemSubGroup_Table)
		/// </summary>
		public int ItemSubGroupKey { get; set; }
		/// <summary>
		/// 아이템목록
		/// </summary>
		public string ItemList { get; set; } = null!;
	}
}
