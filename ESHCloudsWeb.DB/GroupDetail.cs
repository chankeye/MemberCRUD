//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESHCloudsWeb.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupDetail
    {
        public string CN { get; set; }
        public int GroupID { get; set; }
        public string PeopleID { get; set; }
        public string MailType { get; set; }
    
        public virtual PeopleGroup PeopleGroup { get; set; }
    }
}
