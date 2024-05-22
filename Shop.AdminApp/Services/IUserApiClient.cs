using Shop.ViewModels.System.Users;
using System.Threading.Tasks;

namespace Shop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
