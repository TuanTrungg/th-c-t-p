namespace TTNhom_QL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGTON")]
    public partial class HANGTON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGTON()
        {
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
            PHIEUXUATs = new HashSet<PHIEUXUAT>();
        }

        [Key]
        [StringLength(10)]
        public string Idhang { get; set; }

        [StringLength(30)]
        public string Tenhang { get; set; }

        [StringLength(10)]
        public string Dvt { get; set; }

        public int? Soluong { get; set; }

        public int? Gianhap { get; set; }

        public int? Giaxuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUXUAT> PHIEUXUATs { get; set; }
    }
}
