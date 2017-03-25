using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class DiemRenLuyenRepository : BaseRepository<DiemRenLuyen>,IDiemRenLuyenRepository
    {
        public DiemRenLuyenRepository(QLSVDbContext context) : base(context)
        {
        }
    }
}
