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
    
    public partial class uspListXboxCashProductRefundInfo_Result
    {
        public long C_refundNo { get; set; }
        public string C_accountNo { get; set; }
        public string C_ProductId { get; set; }
        public long C_beforeConsumeCount { get; set; }
        public long C_afterConsumeCount { get; set; }
        public bool C_isCheckProductCount { get; set; }
        public long C_beforeProductCount { get; set; }
        public long C_afterProductCount { get; set; }
        public long C_refundCount { get; set; }
        public byte C_refundState { get; set; }
        public System.DateTime C_registerDate { get; set; }
        public Nullable<System.DateTime> C_completeDate { get; set; }
        public Nullable<System.DateTime> C_cancelDate { get; set; }
        public string C_legacyProductId { get; set; }
    }
}