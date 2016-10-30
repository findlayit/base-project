using BaseProject.DataAccess.Common;
using BaseProject.Domain.Users;

namespace BaseProject.DataAccess
{
    public class RoleRepository : BaseRepository<RoleEntity>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}