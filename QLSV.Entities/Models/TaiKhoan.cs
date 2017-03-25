using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_TaiKhoan")]
    public class TaiKhoan : IEntityBase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống.")]
        public string TenDangNhap { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống.")]
        public string MatKhau { get; set; }

        public int LoaiNguoiDung { get; set; }

        public int IdNguoiDung { get; set; }

        public bool Deleted { get; set; }
    }
}
