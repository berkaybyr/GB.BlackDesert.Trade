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
    
    public partial class uspListAuctionLogByReasonLive_Result
    {
        public short C_operationLogType { get; set; }
        public short C_serverNo { get; set; }
        public System.DateTime C_registerDate { get; set; }
        public string C_userId { get; set; }
        public long C_userNo { get; set; }
        public string C_userIp { get; set; }
        public Nullable<bool> C_isUserGm { get; set; }
        public Nullable<long> C_playMinuteOfUser { get; set; }
        public bool C_isPcRoom { get; set; }
        public bool C_isPcRoomPremium { get; set; }
        public Nullable<bool> C_isPvP { get; set; }
        public string C_characterName { get; set; }
        public Nullable<long> C_characterNo { get; set; }
        public Nullable<int> C_characterLevel { get; set; }
        public Nullable<int> C_remainedSkillPoint { get; set; }
        public Nullable<int> C_aquiredSkillPoint { get; set; }
        public Nullable<long> C_playMinuteOfCharacter { get; set; }
        public Nullable<long> C_characterExperience { get; set; }
        public Nullable<int> C_characterTendency { get; set; }
        public Nullable<short> C_currentFieldNo { get; set; }
        public Nullable<long> C_currentPositionX { get; set; }
        public Nullable<long> C_currentPositionY { get; set; }
        public Nullable<long> C_currentPositionZ { get; set; }
        public Nullable<byte> C_regionType { get; set; }
        public Nullable<bool> C_isDoingSiege { get; set; }
        public Nullable<long> C_auctionGoodsNo { get; set; }
        public Nullable<int> C_auctionKey { get; set; }
        public Nullable<long> C_price { get; set; }
        public Nullable<long> C_param1 { get; set; }
        public Nullable<long> C_param2 { get; set; }
        public Nullable<long> C_param3 { get; set; }
        public Nullable<long> C_param4 { get; set; }
        public Nullable<short> C_reason { get; set; }
    }
}