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
    
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.UserFeatureInfoes = new HashSet<UserFeatureInfo>();
            this.AspNetRoles = new HashSet<AspNetRole>();
        }
    
        override public string Id { get; set; }
        override public string UserName { get; set; }
        override public string PasswordHash { get; set; }
        override public string SecurityStamp { get; set; }
        public string Discriminator { get; set; }
    
        public virtual ICollection<UserFeatureInfo> UserFeatureInfoes { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}