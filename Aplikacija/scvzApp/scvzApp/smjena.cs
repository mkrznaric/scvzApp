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
    
    public partial class smjena
    {
        public int idsmjena { get; set; }
        public Nullable<int> dan_u_mjesecu { get; set; }
        public string vrsta_smjene { get; set; }
        public Nullable<int> zaposlenikID { get; set; }
        public Nullable<int> mjesecID { get; set; }
    
        public virtual mjesec mjesec { get; set; }
        public virtual zaposlenik zaposlenik { get; set; }
    }
}
