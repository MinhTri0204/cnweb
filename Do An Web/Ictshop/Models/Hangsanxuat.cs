namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Hangsanxuat")]
    public partial class Hangsanxuat
    {
       
        public Hangsanxuat()
        {
            Sanpham = new HashSet<Sanpham>();
        }

        [Key]
        public int Mahang { get; set; }

        [StringLength(10)]
        public string Tenhang { get; set; }

        public virtual ICollection<Sanpham> Sanpham { get; set; }
    }
}
