using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class SinhVienRepository : BaseRepository<SinhVien>, ISinhVienRepository
    {
        public SinhVienRepository(QLSVDbContext context) : base(context)
        {
        }
    }
}
