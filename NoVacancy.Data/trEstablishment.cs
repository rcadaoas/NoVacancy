//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoVacancy.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class trEstablishment
    {
        public int EstablishmentID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string Name { get; set; }
        public Nullable<int> EstablishmentType { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public int Active { get; set; }
        public Nullable<System.DateTime> DateDeactivated { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DateDeleted { get; set; }
        public int Deleted { get; set; }
        public Nullable<int> Year { get; set; }
    }
}
