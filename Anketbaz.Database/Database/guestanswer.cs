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
    
    public partial class guestanswer
    {
        public long ownerid { get; set; }
        public string ownertype { get; set; }
        public long pollid { get; set; }
        public long questionid { get; set; }
        public long answerid { get; set; }
        public long guestid { get; set; }
    }
}
