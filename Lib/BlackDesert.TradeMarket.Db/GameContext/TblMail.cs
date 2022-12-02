namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 편지 정보
	/// </summary>
	public partial class TblMail
	{
		/// <summary>
		/// 등록 일시
		/// </summary>
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 편지 고유 번호
		/// </summary>
		public long MailNo { get; set; }
		/// <summary>
		/// 보낸 캐릭터 이름
		/// </summary>
		public string SenderName { get; set; } = null!;
		/// <summary>
		/// 보낸 사용자번호
		/// </summary>
		public long SenderUserNo { get; set; }
		/// <summary>
		/// 받는 캐릭터 이름
		/// </summary>
		public string ReceiverName { get; set; } = null!;
		/// <summary>
		/// 받는 사용자번호
		/// </summary>
		public long ReceiverUserNo { get; set; }
		/// <summary>
		/// 편지 제목
		/// </summary>
		public string Title { get; set; } = null!;
		/// <summary>
		/// 편지 내용
		/// </summary>
		public string Contents { get; set; } = null!;
		/// <summary>
		/// 편지 타입
		/// </summary>
		public byte MailType { get; set; }
		/// <summary>
		/// _mailType에 따라 의미 다름
		/// </summary>
		public long? VariousNo { get; set; }
		/// <summary>
		/// 첨부된 아이템 인챈트 레벨
		/// </summary>
		public byte? EnchantLevel { get; set; }
		/// <summary>
		/// 첨부된 아이템 개수
		/// </summary>
		public long? ItemCount { get; set; }
		/// <summary>
		/// 첨부된 아이템 유통기한
		/// </summary>
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// 편지 삭제 시간
		/// </summary>
		public DateTime? DeletedDate { get; set; }
		/// <summary>
		/// 우편발송 웹창고 아이템 구분 (0:인게임메일, 1:쿠폰지급 아이템, 2:패키지, 3:웹샵 아이템, 그외 추가 가능)
		/// </summary>
		public byte WebItemType { get; set; }
		public string? ChargeNo { get; set; }
	}
}
