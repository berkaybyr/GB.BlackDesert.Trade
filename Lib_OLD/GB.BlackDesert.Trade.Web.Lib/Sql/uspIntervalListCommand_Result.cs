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
    
    public partial class uspIntervalListCommand_Result
    {
        public long C_commandNo { get; set; }
        public int C_worldNo { get; set; }
        public Nullable<System.DateTime> C_registerDate { get; set; }
        public string C_commandString { get; set; }
        public Nullable<byte> C_status { get; set; }
        public Nullable<System.DateTime> C_reserveDate { get; set; }
        public Nullable<long> C_interval { get; set; }
        public byte C_type { get; set; }
        public bool C_isCycleCommand { get; set; }
        public System.DateTime C_endDate { get; set; }
    }
}
