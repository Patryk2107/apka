using SavingFileDb;

namespace SavingApiMenager.Services
{
    public abstract class ConnectionService 
    {
        public SavingFileDbContext _context;
        public ConnectionService(SavingFileDbContext context)
        {
            _context = context;
        }

        public ConnectionService()
        {
        }
    }
}
