using BayernData.Models;

namespace BayernData.Data
{
    public class CStaffRepository : CRepositoryBase<Staff>, IStaffRepository
    {
        public CStaffRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
