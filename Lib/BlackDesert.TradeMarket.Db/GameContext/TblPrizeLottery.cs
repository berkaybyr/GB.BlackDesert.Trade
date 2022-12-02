namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 경품 추첨
	/// </summary>
	public partial class TblPrizeLottery
	{
		/// <summary>
		/// NPC키
		/// </summary>
		public int CharacterKey { get; set; }
		/// <summary>
		/// 추첨유저번호
		/// </summary>
		public long EntryUserNo { get; set; }
	}
}
