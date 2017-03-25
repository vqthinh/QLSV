using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_DiemRenLuyen")]
    public class DiemRenLuyen : IEntityBase
    {
        public int Id { get; set; }

        public int SinhVienId { get; set; }

        public int Hk1 { get; set; }

        public int Hk2 { get; set; }

        public int Hk3 { get; set; }

        public int Hk4 { get; set; }

        public int Hk5 { get; set; }

        public int Hk6 { get; set; }

        public int Hk7 { get; set; }

        public int Hk8 { get; set; }

        public int Hk9 { get; set; }

        public int Hk10 { get; set; }

        public bool Deleted { get; set; }

        [ForeignKey("SinhVienId")]
        public virtual SinhVien SinhVien { get; set; }
    }
}
