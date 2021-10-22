namespace BayernData.Data
{
    public class CRepositoryWrapper : IRepositoryWrapper
    {
        IStaffRepository _staffRepository { get; set; }
        AppDbContext _dbContext { get; set; }

        public CRepositoryWrapper(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IStaffRepository staffRepository
        {
            get
            {
                if (_staffRepository == null)
                    _staffRepository = new CStaffRepository(_dbContext);
                return _staffRepository;
            }
        }
    }
}
