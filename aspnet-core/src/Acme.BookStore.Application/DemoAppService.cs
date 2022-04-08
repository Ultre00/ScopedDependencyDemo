using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace Acme.BookStore
{
    public class DemoAppService : BookStoreAppService
    {
        private readonly IRepository<IdentityUser> _userRepositry;
        public DemoAppService(IRepository<IdentityUser> userRepositry)
        {
            _userRepositry = userRepositry;
        }

        public async Task DemoAsync()
        {
            var users = await _userRepositry.ToListAsync();
        } 
    }
}
