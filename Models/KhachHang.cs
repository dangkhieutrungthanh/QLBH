namespace QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(10)]
        public string Address { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }
    }
}
