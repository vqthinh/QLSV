using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_LopSh")]
    public class Lop : IEntityBase
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        public int KhoaId { get; set; }

        public int KhoaHocId { get; set; }

        public bool Deleted { get; set; }
    }
}
