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
    
    public partial class UserFeatureInfo
    {
        public int id { get; set; }
        public string user_id { get; set; }
        public int feature_id { get; set; }
        public int episode_id { get; set; }
        public int status_id { get; set; }
        public Nullable<int> my_rating { get; set; }
        public string file_path { get; set; }
        public Nullable<bool> on_disk { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual Status Status { get; set; }
    }
}
