//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplicationusingEDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerBillingHistory
    {
        public int BillPaymentId { get; set; }
        public System.DateTime BillPaidDate { get; set; }
        public int CustomerMobileNumber { get; set; }
        public int BillPaymentMode { get; set; }
        public decimal BillAmount { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
