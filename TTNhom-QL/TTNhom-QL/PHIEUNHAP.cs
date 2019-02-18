namespace TTNhom_QL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [Key]
        [StringLength(10)]
        public string Idphieun { get; set; }

        [StringLength(10)]
        public string Idhang { get; set; }

        [StringLength(10)]
        public string Idncc { get; set; }

        [StringLength(30)]
        public string Tenhang { get; set; }

        [StringLength(5)]
        public string Dvt { get; set; }

        public int? Luongnhap { get; set; }

        public int? Gianhap { get; set; }

        public int? Thanhtien { get; set; }

        public virtual HANGTON HANGTON { get; set; }

        public virtual NCC NCC { get; set; }
    }
}
