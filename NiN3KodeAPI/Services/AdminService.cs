using NiN3KodeAPI.DbContexts;

namespace NiN3KodeAPI.Services
{
    public class AdminService : IAdminService
    {

        private readonly NiN3DbContext _context;
        public AdminService(IConfiguration configuration, NiN3DbContext context) { 
            _context = context;
        }

        public async Task<IEnumerable<Domene>> HentDomenerAsync()
        {
            return await _context.domene.OrderBy(c => c.Navn).ToListAsync();
        }
    }
}
