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
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.CustomerBillingHistories = new HashSet<CustomerBillingHistory>();
        }
    
        public int MobileNumber { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string CustomersIdentity { get; set; }
        public int EmployeeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerBillingHistory> CustomerBillingHistories { get; set; }
        public virtual Employee Employee { get; set; }
    }
}