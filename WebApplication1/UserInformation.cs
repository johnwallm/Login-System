//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInformation
    {
        public int UserInformationID { get; set; }
        public int UserTypeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string GivenName { get; set; }
        public string MaidenName { get; set; }
        public string FamilyName { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
    
        public virtual UserType UserType { get; set; }
    }
}
