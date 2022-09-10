namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            Nguoidung = new HashSet<Nguoidung>();
        }

        [Key]
        public int IDQuyen { get; set; }

        [StringLength(20)]
        public string TenQuyen { get; set; }

        public virtual ICollection<Nguoidung> Nguoidung { get; set; }
    }
}
