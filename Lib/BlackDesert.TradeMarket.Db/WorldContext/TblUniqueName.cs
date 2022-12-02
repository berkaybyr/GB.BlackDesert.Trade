namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유일한 이름
	/// </summary>
	public partial class TblUniqueName
	{
		/// <summary>
		/// 생성일
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 0 캐릭터명,1 길드명, 2 가문명(enum NameType)
		/// </summary>
		public byte Type { get; set; }
		/// <summary>
		/// 해당번호
		/// </summary>
		public long VariousNo { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		public string Name { get; set; } = null!;
		/// <summary>
		/// 월드번호
		/// </summary>
		public short WorldNo { get; set; }
		/// <summary>
		/// 삭제일
		/// </summary>
		public DateTime? DeletedDate { get; set; }
		public byte SubType { get; set; }
	}
}
