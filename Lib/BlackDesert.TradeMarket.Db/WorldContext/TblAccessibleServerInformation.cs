namespace BlackDesert.TradeMarket.Db.WorldContext
{
	/// <summary>
	/// 유저별 접속가능한 게임서버(채널번호)
	/// </summary>
	public partial class TblAccessibleServerInformation
	{
		/// <summary>
		/// 월드 번호
		/// </summary>
		public short WorldNo { get; set; }
		/// <summary>
		/// 유저 번호
		/// </summary>
		public long UserNo { get; set; }
		/// <summary>
		/// 서버 번호(채널)
		/// </summary>
		public short? ServerNo { get; set; }
		/// <summary>
		/// 작업중 이라서 이곳으로 접속 가능
		/// </summary>
		public bool? IsWorking { get; set; }
		/// <summary>
		/// 이 시간이 지나야 채널 이동을 할 수 있다
		/// </summary>
		public DateTime? MoveableTime { get; set; }
		/// <summary>
		/// 이 시간이 지나야 특수 채널 이동을 할 수 있다
		/// </summary>
		public DateTime? MoveableSpecialChannelTime { get; set; }
		public short? ServerGroupNo { get; set; }
		public byte RestrictReason { get; set; }
	}
}
