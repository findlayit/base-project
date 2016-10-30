using BaseProject.Domain.Users;

namespace BaseProject.DataAccess
{
    public interface ITokenRepository
    {
        TokenEntity Get(string username, string hash);
        void Set(string username, string hash, TokenEntity data);
        void Delete(string username, string hash);
    }
}