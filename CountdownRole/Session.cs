//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CountdownRole
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        public int SessionID { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public int CreatorID { get; set; }
        public System.Guid SessionKey { get; set; }
        public bool Finished { get; set; }
    
        public virtual User User { get; set; }
    }
}
