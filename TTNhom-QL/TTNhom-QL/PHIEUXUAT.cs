namespace TTNhom_QL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUXUAT")]
    public partial class PHIEUXUAT
    {
        [Key]
        [StringLength(10)]
        public string Idphieux { get; set; }

        [StringLength(10)]
        public string Idhang { get; set; }

        [StringLength(30)]
        public string Tenhang { get; set; }

        [StringLength(5)]
        public string Dvt { get; set; }

        public int? Luongxuat { get; set; }

        public int? Giaxuat { get; set; }

        public int? Thanhtien { get; set; }

        public virtual HANGTON HANGTON { get; set; }
    }
}
