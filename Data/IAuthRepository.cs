using System.Threading.Tasks;
using sampleAPI.Models;

namespace sampleAPI.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Regsiter(User user,string password);
        Task<ServiceResponse<string>> Login(string username,string password);
        Task<bool> UserExists(string username);
    }
}