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
    
    public partial class student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public student()
        {
            this.kvar = new HashSet<kvar>();
            this.racun = new HashSet<racun>();
        }
    
        public int idstudent { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public Nullable<int> zupanija { get; set; }
        public string spol { get; set; }
        public Nullable<System.DateTime> datum_rodjenja { get; set; }
        public Nullable<int> student_soba { get; set; }
        public int fakultet { get; set; }
    
        public virtual fakultet fakultet1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kvar> kvar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<racun> racun { get; set; }
        public virtual soba soba { get; set; }
        public virtual zupanija zupanija1 { get; set; }
    }
}
