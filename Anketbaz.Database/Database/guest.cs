//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anketbaz.Database.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class guest
    {
        public long ownerid { get; set; }
        public string ownertype { get; set; }
        public long pollid { get; set; }
        public long guestid { get; set; }
        public string ip { get; set; }
        public string fielddata { get; set; }
        public Nullable<int> complatesecond { get; set; }
        public string crdat { get; set; }
        public string crtim { get; set; }
    }
}
