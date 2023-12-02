using BasicAuthExample.Model;

namespace BasicAuthExample.Auth
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }
}
