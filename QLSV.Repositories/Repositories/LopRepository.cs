using QLSV.Abstract.Repositories;
using QLSV.Entities.Models;

namespace QLSV.Repositories.Repositories
{
    public class LopRepository : BaseRepository<Lop>,ILopRepository
    {
        public LopRepository(QLSVDbContext context) : base(context)
        {
        }
    }
}
