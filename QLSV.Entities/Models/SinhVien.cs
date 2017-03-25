using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_SinhVien")]
    public class SinhVien : IEntityBase
    {
        public int Id { get; set; }

        public string HoDem { get; set; }

        public string MaSv { get; set; }

        public string Ten { get; set; }

        public int? LopHocId { get; set; }

        public int? KhoaHocId { get; set; }

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

        public string HoTenCha { get; set; }

        public string DienThoaiCha { get; set; }

        public string HoTenMe { get; set; }

        public string DienThoaiMe { get; set; }

        public bool GioiTinh { get; set; }

        public int? KhoaId { get; set; }
        [ForeignKey("LopHocId")]
        public virtual Lop Lop { get; set; }

        [ForeignKey("KhoaId")]
        public virtual Khoa Khoa { get; set; }

        public bool Deleted { get; set; }

        [NotMapped]
        public string TenDayDu => HoDem + " " + Ten;
    }
}
