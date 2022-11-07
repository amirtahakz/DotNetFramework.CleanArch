using Domain.UserAgg.Repository;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using Domain.UserAgg;
using Infrastructure.Utilities;

namespace Infrastructure.Persistent.Ef.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
