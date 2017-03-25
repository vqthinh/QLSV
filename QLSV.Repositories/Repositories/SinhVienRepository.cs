﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class SinhVienRepository : BaseRepository<SinhVien>, ISinhVienRepository
    {
        private readonly QLSVDbContext _context;
        public SinhVienRepository(QLSVDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Khoa> GetKhoas()
        {
            return _context.Set<Khoa>().ToList();
        }
    }
}
