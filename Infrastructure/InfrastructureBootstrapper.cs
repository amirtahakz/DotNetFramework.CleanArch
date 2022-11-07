using Domain.RoleAgg.Repository;
using Domain.UserAgg.Repository;
using Infrastructure.Persistent.Ef.Users;
using Infrastructure.Persistent.Ef;
using System.Data.Entity.Core.Metadata.Edm;
using Unity;
using Unity.Injection;

namespace Infrastructure
{
    public static class InfrastructureBootstrapper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}
