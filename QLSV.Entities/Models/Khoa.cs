using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("khoa")]
    public class Khoa : IEntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ten_khoa")]
        public string TenKhoa { get; set; }
        [Column("ten_viet_tat")]
        public string TenVietTat { get; set; }
        [NotMapped]
        public bool Deleted { get; set; }
    }
}
