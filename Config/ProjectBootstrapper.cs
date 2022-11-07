using Application.Users;
using Application.Users.Services;
using Domain.UserAgg.Services;
using Infrastructure;
using Unity;

namespace Config
{
    public static class ProjectBootstrapper
    {
        public static void Init(UnityContainer container)
        {
            InfrastructureBootstrapper.Init(container);


            container.RegisterType<IUserDomainService, UserDomainService>();


            container.RegisterType<IUserService, UserService>();
        }
    }
}