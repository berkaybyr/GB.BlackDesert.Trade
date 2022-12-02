namespace BlackDesert.TradeMarket.Db.GameContext
{
	/// <summary>
	/// 하우징 설치오브젝트 텐트 테이블
	/// </summary>
	public partial class TblInstallation
	{
		/// <summary>
		/// _installationNo
		/// </summary>
		public long InstallationNo { get; set; }
		/// <summary>
		/// 배치된 설치물 아이템 번호
		/// </summary>
		public long ItemNo { get; set; }
		/// <summary>
		/// _fieldNo
		/// </summary>
		public short FieldNo { get; set; }
		/// <summary>
		/// _fieldIndex
		/// </summary>
		public short FieldIndex { get; set; }
		/// <summary>
		/// _posX
		/// </summary>
		public double PosX { get; set; }
		/// <summary>
		/// _posY
		/// </summary>
		public double PosY { get; set; }
		/// <summary>
		/// _posZ
		/// </summary>
		public double PosZ { get; set; }
		/// <summary>
		/// _quatX
		/// </summary>
		public double QuatX { get; set; }
		/// <summary>
		/// _quatY
		/// </summary>
		public double QuatY { get; set; }
		/// <summary>
		/// _quatZ
		/// </summary>
		public double QuatZ { get; set; }
		/// <summary>
		/// _quatW
		/// </summary>
		public double QuatW { get; set; }
		/// <summary>
		/// 설비도구 공개설정: 0(공개), 1:(고정집안에서공개) 2:(여관안에서 공개)
		/// </summary>
		public byte PrivateFlag { get; set; }
		/// <summary>
		/// 설비도구가 처음 설치된 시간
		/// </summary>
		public DateTime InstallDate { get; set; }
		/// <summary>
		/// 설비도구가 작물일때, 성장정도
		/// </summary>
		public int ProgressPercent { get; set; }
		/// <summary>
		/// 설비도구가 작물일때, 시듦 수치
		/// </summary>
		public int NeedWaterPercent { get; set; }
		/// <summary>
		/// 설비도구가 작물일때, 작물 수확량 감소%
		/// </summary>
		public int DecreaseYieldPercent { get; set; }
		/// <summary>
		/// 설비도구가 작물일때, 가지치기가 필요한 상태
		/// </summary>
		public bool NeedLop { get; set; }
		/// <summary>
		/// 설비도구가 작물일때, 병충해정리가 필요한 상태
		/// </summary>
		public bool NeedPestControl { get; set; }
		/// <summary>
		/// 고정집이 반납될때 삭제되는 설비도구
		/// </summary>
		public bool IsErase { get; set; }
		/// <summary>
		/// 설비도구 타입에 따라서 맞춰서 사용
		/// </summary>
		public long Param0 { get; set; }
		/// <summary>
		/// 설비도구 타입에 따라서 맞춰서 사용
		/// </summary>
		public double Param1 { get; set; }
		/// <summary>
		/// 인테리어 추가 점수에 따른 연관 설비도구 번호
		/// </summary>
		public long? RelativeInstallationNo { get; set; }
	}
}
