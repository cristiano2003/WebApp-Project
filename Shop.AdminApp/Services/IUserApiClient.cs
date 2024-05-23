using Shop.ViewModels.Common;
using Shop.ViewModels.System.Users;
using System.Threading.Tasks;

namespace Shop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PageResult<UserVm>> GetUsersPagings(GetUserPagingRequest request); 

        Task<bool> RegisterUser(RegisterRequest request);
    }
}
