using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_MonHoc")]
    public class MonHoc : IEntityBase
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        public string MaMonHoc { get; set; }

        public bool Deleted { get; set; }
    }
}
