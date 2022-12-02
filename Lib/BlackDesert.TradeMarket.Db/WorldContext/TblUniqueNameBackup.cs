namespace BlackDesert.TradeMarket.Db.WorldContext
{
	public partial class TblUniqueNameBackup
	{
		public string BackupDate { get; set; } = null!;
		public DateTime RegisterDate { get; set; }
		public byte Type { get; set; }
		public long VariousNo { get; set; }
		public string Name { get; set; } = null!;
		public short WorldNo { get; set; }
		public DateTime? DeletedDate { get; set; }
	}
}
