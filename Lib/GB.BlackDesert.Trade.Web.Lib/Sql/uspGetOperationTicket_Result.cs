//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackDesert.TradeMarket.Lib.Sql
{
    using System;
    
    public partial class uspGetOperationTicket_Result
    {
        public System.DateTime C_registerDate { get; set; }
        public long C_ticketNo { get; set; }
        public short C_worldNo { get; set; }
        public string C_characterName { get; set; }
        public string C_userId { get; set; }
        public byte C_requestType { get; set; }
        public string C_requestList { get; set; }
        public string C_reason { get; set; }
        public long C_gmUserNo { get; set; }
        public byte C_priority { get; set; }
        public byte C_ticketState { get; set; }
        public Nullable<long> C_approvedUserNo { get; set; }
        public System.DateTime C_updatedDate { get; set; }
        public string C_confirmReason { get; set; }
    }
}
