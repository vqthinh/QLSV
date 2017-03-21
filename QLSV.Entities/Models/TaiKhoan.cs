using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tai_khoan_dang_nhap")]
    public class TaiKhoan : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống.")]
        [Column("ten_dang_nhap")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống.")]
        [Column("mat_khau")]
        public string MatKhau { get; set; }
        [Column("loai_nguoi_dung")]
        public int LoaiNguoiDung { get; set; }
        [Column("id_nguoi_dung")]
        public int IdNguoiDung { get; set; }
        [NotMapped]
        public bool Deleted { get; set; }
    }
}
