//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Search
    {
        public int codeSearch { get; set; }
        public int codeUser { get; set; }
        public string nameProduct { get; set; }
        public int codeCategory { get; set; }
        public int status { get; set; }
        public Nullable<int> codeShop { get; set; }
        public Nullable<int> distance { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
