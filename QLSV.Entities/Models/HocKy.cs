using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_HocKy")]
    public class HocKy : IEntityBase
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        public int NamHocId { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public bool IsActive { get; set; }

        public bool Deleted { get; set; }
    }
}
