//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace scvzApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class racun_usluga
    {
        public int racun_idracun { get; set; }
        public int usluga_idusluga { get; set; }
        public short kolicina { get; set; }
    
        public virtual racun racun { get; set; }
        public virtual usluga usluga { get; set; }
    }
}
