//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Schooldatabase.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentDetail
    {
        public int Roll_No { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
    
        public virtual StudentMark StudentMark { get; set; }
    }
}
