//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GB.BlackDesert.Trade.Web.Lib.Sql
{
    using System;
    
    public partial class uspListWebBoardGameLogByCharacterName_Result
    {
        public short C_operationLogType { get; set; }
        public short C_serverNo { get; set; }
        public System.DateTime C_registerDate { get; set; }
        public string C_userId { get; set; }
        public long C_userNo { get; set; }
        public string C_userIp { get; set; }
        public string C_characterName { get; set; }
        public Nullable<long> C_characterNo { get; set; }
        public byte C_diceValue { get; set; }
        public byte C_startPosition { get; set; }
        public byte C_dicePosition { get; set; }
        public byte C_nowPosition { get; set; }
        public int C_finishCount { get; set; }
        public byte C_todayCount { get; set; }
        public Nullable<byte> C_prizeType { get; set; }
        public Nullable<long> C_param0 { get; set; }
        public Nullable<long> C_param1 { get; set; }
        public short C_reason { get; set; }
    }
}
