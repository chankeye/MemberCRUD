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
    
    public partial class AlarmUpdate
    {
        public int UpdateID { get; set; }
        public string CN { get; set; }
        public string AlarmID { get; set; }
        public System.DateTime StartAlarmDate { get; set; }
        public System.DateTime NextAlarmDate { get; set; }
        public int AlarmCount { get; set; }
        public System.DateTime RenewalDueDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateMemo { get; set; }
        public System.DateTime EstablishDate { get; set; }
        public string UpdatePeople { get; set; }
        public string Status { get; set; }
    
        public virtual AlarmMaster AlarmMaster { get; set; }
    }
}