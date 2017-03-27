using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_LopHocPhan")]
    public class LopHocPhan : IEntityBase
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        public string MaLopHp { get; set; }

        public int SoTinChi { get; set; }

        public int MonHocId { get; set; }

        public int HocKyId { get; set; }

        public int NgayHoc1 { get; set; }

        public int NgayHoc2 { get; set; }

        public string TietHoc1 { get; set; }

        public string TietHoc2 { get; set; }

        public DateTime NgayBatDau { get; set; }

        public int GiaoVienId { get; set; }

        public int SoLuongChoPhep { get; set; }

        public bool Deleted { get; set; }
    }
}
