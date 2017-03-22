using System.Collections.Generic;
using System.Linq;
using QLSV.Abstract.Repositories;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;

namespace QLSV.Services.Services
{
    public class SinhVienService : BaseService<SinhVien>,ISinhVienService
    {
        private readonly ISinhVienRepository _sinhVienRepository;

        public SinhVienService()
        {
            _sinhVienRepository = UnitOfWork.Repository<SinhVien>() as ISinhVienRepository;
        }

        public IList<SinhVien> GetListSinhViens(string keyword, int page, int size)
        {
            if (string.IsNullOrEmpty(keyword))
                return _sinhVienRepository.GetPage(p => p.OrderBy(x => x.MaSv), null, page, size);
            return _sinhVienRepository.GetPage(p => p.OrderBy(x => x.MaSv), p => p.Ten.ToLower().Contains(keyword.ToLower()) || p.HoDem.ToLower().Contains(keyword.ToLower()), page, size);
        }

        public IList<Khoa> GetKhoa()
        {
            return _sinhVienRepository.GetKhoas();
        }
    }
}
