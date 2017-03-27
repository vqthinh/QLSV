using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_GiaoVien")]
    public class GiaoVien : IEntityBase
    {
        public int Id { get; set; }

        public string HoDem { get; set; }

        public string MaGv { get; set; }

        public string Ten { get; set; }

        public DateTime? NgaySinh { get; set; }

        public string HoKhau { get; set; }

        public string QuocTich { get; set; }

        public string DiaChi { get; set; }

        public string NoiSinh { get; set; }

        public string DanToc { get; set; }

        public string DienThoai { get; set; }

        public string Email { get; set; }

        public string Cmnd { get; set; }

        public DateTime? NgayCap { get; set; }

        public string NoiCap { get; set; }

        public bool GioiTinh { get; set; }

        public bool Deleted { get; set; }

        [NotMapped]
        public string TenDayDu => HoDem + " " + Ten;
    }
}
