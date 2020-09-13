using System.Threading.Tasks;
using DatingApp.API.Models;

// authentication repostory interface here
namespace DatingApp.API.Data
{
    public interface IAuthRepostiory
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);

    }
}