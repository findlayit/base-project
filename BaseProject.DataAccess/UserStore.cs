using BaseProject.Domain.Users;
using FlexProviders.EF;

namespace BaseProject.DataAccess
{
    public class UserStore : FlexMembershipUserStore<UserEntity>
    {
        public UserStore(UserContext db)
            : base(db)
        {
        }
    }
}