using BaseProject.DataAccess.Common;
using BaseProject.Domain.Users;

namespace BaseProject.DataAccess
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        UserEntity FindByUsername(string username);
        UserEntity Register(string username, string password, string role, string firstName, string lastName);
        LoginResult Login(string username, string password);
        bool AccountLogin(string username, string password);
        bool ChangePassword(string username, string oldPassword, string newPassword);
        void Dispose();
    }
}