namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hedieuhanh")]
    public partial class Hedieuhanh
    {
        public Hedieuhanh()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        [Key]
        public int Mahdh { get; set; }

        [StringLength(10)]
        public string Tenhdh { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
