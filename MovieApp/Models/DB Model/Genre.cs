//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieApp.Models.DB_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genre
    {
        public Genre()
        {
            this.Features = new HashSet<Feature>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Feature> Features { get; set; }
    }
}