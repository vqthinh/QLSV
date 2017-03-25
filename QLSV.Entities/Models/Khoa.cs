using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_Khoa")]
    public class Khoa : IEntityBase
    {
        public int Id { get; set; }

        public string Ten{ get; set; }

        public bool Deleted { get; set; }
    }
}
