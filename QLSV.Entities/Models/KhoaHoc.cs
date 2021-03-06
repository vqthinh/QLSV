﻿using System.ComponentModel.DataAnnotations.Schema;

namespace QLSV.Entities.Models
{
    [Table("tbl_KhoaHoc")]
    public class KhoaHoc : IEntityBase
    {
        public int Id { get; set; }

        public string Ten { get; set; }

        public int NamBatDau { get; set; }

        public int NamKetThuc { get; set; }

        public bool Deleted { get; set; }
    }
}
