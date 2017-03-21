using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("sinh_vien")]
    public class SinhVien : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ho_dem")]
        public string HoDem { get; set; }
        [Column("ma_sinh_vien")]
        public string MaSv { get; set; }
        [Column("ten")]
        public string Ten { get; set; }
        [Column("lop_hoc_id")]
        public int LopHocId { get; set; }
        [Column("khoa_hoc")]
        public int? KhoaHocId { get; set; }
        [Column("ngay_sinh")]
        public DateTime? NgaySinh { get; set; }
        [Column("ho_khau")]
        public string HoKhau { get; set; }
        [Column("quoc_tich")]
        public int? QuocTich { get; set; }
        [Column("dia_chi_lien_lac")]
        public string DiaChi { get; set; }
        [Column("noi_sinh")]
        public string NoiSinh { get; set; }
        [Column("dan_toc")]
        public string DanToc { get; set; }
        [Column("dien_thoai")]
        public string DienThoai { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("so_cmnd")]
        public string Cmnd { get; set; }
        [Column("ngay_cap")]
        public DateTime? NgayCap { get; set; }
        [Column("noi_cap")]
        public string NoiCap { get; set; }
        [Column("ho_ten_cha")]
        public string HoTenCha { get; set; }
        [Column("dien_thoai_cha")]
        public string DienThoaiCha { get; set; }
        [Column("ho_ten_me")]
        public string HoTenMe { get; set; }
        [Column("dien_thoai_me")]
        public string DienThoaiMe { get; set; }
        [Column("gioi_tinh")]
        public bool? GioiTinh { get; set; }
        [Column("khoa_id")]
        public int? KhoaId { get; set; }
        [ForeignKey("LopHocId")]
        public virtual Lop Lop { get; set; }
        [ForeignKey("KhoaId")]
        public virtual Khoa Khoa { get; set; }
        [Column("trang_thai")]
        public bool Deleted { get; set; }
        [NotMapped]
        public string TenLop => Lop.Ten;
        [NotMapped]
        public string TenKhoa => Khoa.TenKhoa;
    }
}
